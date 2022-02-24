using Storage.Cache.Licenses;
using Storage.Cache.Orders;
using Storage.Cache.Products;
using Storage.Cache.Tables;
using Storage.Cache.Waiters;

namespace Storage.Cache;

public class AllCache
{
    public ILicensesCache LicensesCache { get; }

    public IOrdersCache OrdersCache { get; }

    public IProductsCache ProductsCache { get; }

    public ITablesCache TablesCache { get; }

    public IWaitersCache WaitersCache { get; }

    public AllCache()
    {
        LicensesCache = new LicensesCache();
        OrdersCache = new OrdersCache();
        ProductsCache = new ProductsCache();
        TablesCache = new TablesCache();
        WaitersCache = new WaitersCache();
    }
}