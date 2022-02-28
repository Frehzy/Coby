#nullable enable

using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations;

internal static class Helper
{
    public static Waiter? WaiterById(AllCache cache, Guid waiterId, out Waiter? waiter)
    {
        CheckCacheOnNull(cache);
        waiter = cache.WaitersCache.GetWaitersCache().FirstOrDefault(x => x.Id.Equals(waiterId));
        return waiter;
    }

    public static Waiter? WaiterByPassword(AllCache cache, string password, out Waiter? waiter)
    {
        CheckCacheOnNull(cache);
        waiter = cache.WaitersCache.GetWaitersCache().FirstOrDefault(x => x.Password.Equals(password));
        return waiter;
    }

    public static Table? TableByNumber(AllCache cache, int tableNumber, out Table? table)
    {
        CheckCacheOnNull(cache);
        table = cache.TablesCache.GetTablesCache().FirstOrDefault(x => x.TableNumber.Equals(tableNumber));
        return table;
    }

    public static Nomenclature NomenclatureByParentAndChildId(AllCache cache, Guid parentId, Guid childId, out Nomenclature nomenclature)
    {
        CheckCacheOnNull(cache);
        nomenclature = cache.NomenclatureCache.GetNomenclaturesCache().FirstOrDefault(x => x.ParentId.Equals(parentId) && x.ChildId.Equals(childId));
        return nomenclature;
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

    public static Guest? GuestOnOrderById(AllCache cache, Guid orderId, Guid guestId, out Guest? guest)
    {
        if (OrderById(cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderOnCache.Id);

        guest = orderOnCache.Guests?.Values.FirstOrDefault(x => x.Id.Equals(guestId));
        return guest;
    }

    public static Product? ProductById(AllCache cache, Guid productId, out Product product)
    {
        CheckCacheOnNull(cache);
        product = cache.ProductsCache.GetProductsCache().FirstOrDefault(x => x.Id.Equals(productId));
        return product;
    }

    public static Product? ProductByName(AllCache cache, string name, out Product product)
    {
        CheckCacheOnNull(cache);
        product = cache.ProductsCache.GetProductsCache().FirstOrDefault(x => x.ProductName.Equals(name));
        return product;
    }

    public static Product? ProductOnOrderById(AllCache cache, Guid orderId, Guid productId, int rank, out Product? product)
    {
        if (OrderById(cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderOnCache.Id);

        product = orderOnCache.Guests?.Values.Select(x => x.Products)
            .FirstOrDefault(x => x.Any(x => x.Key.Equals(rank) && x.Value.Id.Equals(productId))).Values?.First();
        return product;
    }

    public static PaymentType PaymentTypeByName(AllCache cache, string name, out PaymentType paymentType)
    {
        CheckCacheOnNull(cache);
        paymentType = cache.PaymentTypesCache.GetPaymentTypesCache().FirstOrDefault(x => x.Name.Equals(name));
        return paymentType;
    }

    public static Payment? PaymentById(AllCache cache, Guid orderId, Guid paymentTypeId, out Payment? payment)
    {
        if (OrderById(cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderOnCache.Id);

        payment = orderOnCache.Payment?.Values.FirstOrDefault(x => x.Id.Equals(paymentTypeId));
        return payment;
    }

    private static bool CheckCacheOnNull(AllCache cache) =>
        cache is not null ? true : throw new ArgumentNullException("Cache cannot be null.");
}
