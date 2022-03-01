#nullable enable

using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Operations;

internal static class Helper
{
    public static Waiter? WaiterById(AllCache cache, Guid waiterId, out Waiter? waiter)
    {
        CheckCacheOnNull(cache);
        return waiter = cache.WaitersCache.GetWaitersCache().FirstOrDefault(x => x.Id.Equals(waiterId));
    }

    public static Waiter? WaiterByPassword(AllCache cache, string password, out Waiter? waiter)
    {
        CheckCacheOnNull(cache);
        return waiter = cache.WaitersCache.GetWaitersCache().FirstOrDefault(x => x.Password.Equals(password));
    }

    public static Table? TableById(AllCache cache, Guid tableId, out Table? table)
    {
        CheckCacheOnNull(cache);
        return table = cache.TablesCache.GetTablesCache().FirstOrDefault(x => x.Id.Equals(tableId));
    }

    public static Table? TableByNumber(AllCache cache, int tableNumber, out Table? table)
    {
        CheckCacheOnNull(cache);
        return table = cache.TablesCache.GetTablesCache().FirstOrDefault(x => x.TableNumber.Equals(tableNumber));
    }

    public static List<Nomenclature> NomenclatureByParentId(AllCache cache, Guid parentId, out List<Nomenclature> nomenclature)
    {
        CheckCacheOnNull(cache);
        return nomenclature = cache.NomenclatureCache.GetNomenclaturesCache()
                                                     .Where(x => x.ParentId.Equals(parentId)).ToList();
    }

    public static Nomenclature NomenclatureByParentAndChildId(AllCache cache, Guid parentId, Guid childId, out Nomenclature nomenclature)
    {
        CheckCacheOnNull(cache);
        return nomenclature = cache.NomenclatureCache.GetNomenclaturesCache()
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
        return order = cache.OrdersCache.GetOrdersCache().FirstOrDefault(x => x.Id.Equals(orderId));
    }

    public static PaymentType PaymentTypeById(AllCache cache, Guid paymentTypeId, out PaymentType paymentType)
    {
        CheckCacheOnNull(cache);
        return paymentType = cache.PaymentTypesCache.GetPaymentTypesCache().FirstOrDefault(x => x.Id.Equals(paymentTypeId));
    }

    public static Guest? GuestOnOrderById(AllCache cache, Guid orderId, Guid guestId, out Order order, out Guest? guest)
    {
        if (OrderById(cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderOnCache.Id);

        order = orderOnCache;
        return guest = orderOnCache.Guests?.Values.FirstOrDefault(x => x.Id.Equals(guestId));
    }

    public static Product? ProductById(AllCache cache, Guid productId, out Product product)
    {
        CheckCacheOnNull(cache);
        return product = cache.ProductsCache.GetProductsCache().FirstOrDefault(x => x.Id.Equals(productId));
    }

    public static Product? ProductByName(AllCache cache, string name, out Product product)
    {
        CheckCacheOnNull(cache);
        return product = cache.ProductsCache.GetProductsCache().FirstOrDefault(x => x.ProductName.Equals(name));
    }

    public static Product? ProductOnOrderById(AllCache cache, Guid orderId, Guid productId, int rank, out Order order, out Product? product)
    {
        if (OrderById(cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderOnCache.Id);

        order = orderOnCache;
        return product = orderOnCache.Guests?.Values.Select(x => x.Products)
                                                    .FirstOrDefault(x => x.Any(x => x.Key.Equals(rank) && x.Value.Id.Equals(productId))).Values?.First();
    }

    public static PaymentType PaymentTypeByName(AllCache cache, string name, out PaymentType paymentType)
    {
        CheckCacheOnNull(cache);
        return paymentType = cache.PaymentTypesCache.GetPaymentTypesCache().FirstOrDefault(x => x.Name.Equals(name));
    }

    public static Payment? PaymentById(AllCache cache, Guid orderId, Guid paymentTypeId, out Order order, out Payment? payment)
    {
        if (OrderById(cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderOnCache.Id);

        order = orderOnCache;
        return payment = orderOnCache.Payment?.Values.FirstOrDefault(x => x.Id.Equals(paymentTypeId));
    }

    private static bool CheckCacheOnNull(AllCache cache) =>
        cache is not null ? true : throw new ArgumentNullException("Cache cannot be null.");
}
