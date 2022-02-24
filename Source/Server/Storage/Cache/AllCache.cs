using Storage.Cache.Licenses;
using Storage.Cache.Orders;
using Storage.Cache.Products;
using Storage.Cache.Tables;
using Storage.Cache.Waiters;

namespace Storage.Cache;

public class AllCache
{
    public ILicensesCache Licenses { get; }

    public IOrdersCache Orders { get; }

    public IProductsCache Products { get; }

    public ITablesCache Tables { get; }

    public IWaitersCache Waiters { get; }

    public AllCache()
    {
        Licenses = new LicensesCache();
        Orders = new OrdersCache();
        Products = new ProductsCache();
        Tables = new TablesCache();
        Waiters = new WaitersCache();
    }
}