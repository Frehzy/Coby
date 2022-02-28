#nullable enable

using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations;

internal static class Helper
{
    public static Waiter? WaiterByPassword(AllCache cache, string password)
    {
        CheckCacheOnNull(cache);
        return cache.WaitersCache.GetWaitersCache()
                                 .FirstOrDefault(x => x.Password.Equals(password));
    }

    public static Nomenclature NomenclatureByParentAndChildId(AllCache cache, Guid parentId, Guid childId)
    {
        CheckCacheOnNull(cache);
        return cache.NomenclatureCache.GetNomenclaturesCache()
                                      .FirstOrDefault(x => x.ParentId.Equals(parentId) && x.ChildId.Equals(childId));
    }

    public static License CheckLicense(AllCache cache, Credentials credentials)
    {
        CheckCacheOnNull(cache);
        return cache.LicensesCache.GetLicensesCache().FirstOrDefault(x => x.Id.Equals(credentials.WaiterId));
    }

    public static Order OrderById(AllCache cache, Guid orderId, out Order order)
    {
        CheckCacheOnNull(cache);
        order = cache.OrdersCache.GetOrdersCache().FirstOrDefault(x => x.Id.Equals(orderId));
        return order;
    }

    public static PaymentType PaymentTypeById(AllCache cache, Guid paymentTypeId)
    {
        CheckCacheOnNull(cache);
        return cache.PaymentTypesCache.GetPaymentTypesCache().FirstOrDefault(x => x.Id.Equals(paymentTypeId));
    }

    public static PaymentType PaymentTypeByName(AllCache cache, string name, out PaymentType paymentType)
    {
        CheckCacheOnNull(cache);
        paymentType = cache.PaymentTypesCache.GetPaymentTypesCache().FirstOrDefault(x => x.Name.Equals(name));
        return paymentType;
    }

    public static Payment? PaymentOnOrderById(AllCache cache, Guid orderId, Guid paymentTypeId, out Payment? payment)
    {
        if (OrderById(cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderOnCache.Id);

        payment = orderOnCache.Payment?.Values.FirstOrDefault(x => x.Id.Equals(paymentTypeId));
        return payment;
    }

    private static bool CheckCacheOnNull(AllCache cache) =>
        cache is not null ? true : throw new ArgumentNullException("Cache cannot be null.");
}
