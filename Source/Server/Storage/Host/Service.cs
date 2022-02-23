using Storage.Cache.License;
using Storage.Cache.Order;
using Storage.Cache.Product;
using Storage.Cache.Table;
using Storage.Cache.Waiters;
using Storage.Operations;
using Storage.Operations.Implementation;
using System.ServiceModel;

namespace Storage.Host;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    private readonly OrdersCache _orders = new();
    private readonly ProductsCache _products = new();
    private readonly WaitersCache _waiters = new();
    private readonly LicensesCache _licenses = new();
    private readonly TablesCache _tables = new();

    public ILicensesCache GetLicensesCache() => _licenses;

    public IOrdersCache GetOrdersCache() => _orders;

    public IProductsCache GetProductsCache() => _products;

    public ITablesCache GetTablesCache() => _tables;

    public IWaitersCache GetWaitersCache() => _waiters;

    ILicenseOperation IService.LicenseOperation() => new LicenseOperation(_licenses, _waiters);

    IOrderOperation IService.OrderOperation() => new OrderOperation(_licenses, _waiters, _tables, _orders);
}