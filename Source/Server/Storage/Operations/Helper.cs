#nullable enable

using Shared.Dto.Enities;
using Storage.Cache;
using Storage.DataBase;
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

    public static List<Nomenclature> NomenclatureByChildId(AllCache cache, Guid childId, out List<Nomenclature> nomenclature)
    {
        CheckCacheOnNull(cache);
        return nomenclature = cache.NomenclatureCache.GetNomenclaturesCache()
                                                     .Where(x => x.ChildId.Equals(childId)).ToList();
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

    public static List<WaiterFace> WaiterFaceById(AllCache cache, Guid waiterFaceId, out List<WaiterFace> waiterFaceOnCache)
    {
        CheckCacheOnNull(cache);
        return waiterFaceOnCache = cache.WaiterFaceCache.GetWaiterFacesCache().Where(x => x.Id.Equals(waiterFaceId)).ToList();
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

    public static PaymentType PaymentTypeByName(AllCache cache, string name, out PaymentType paymentType)
    {
        CheckCacheOnNull(cache);
        return paymentType = cache.PaymentTypesCache.GetPaymentTypesCache().FirstOrDefault(x => x.Name.Equals(name));
    }

    private static bool CheckCacheOnNull(AllCache cache) =>
        cache is not null ? true : throw new ArgumentNullException("Cache cannot be null.");
}
