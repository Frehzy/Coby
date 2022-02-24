using Storage.Cache;
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

    public LicensesCache GetLicensesCache() => _licenses;

    public OrdersCache GetOrdersCache() => _orders;

    public ProductsCache GetProductsCache() => _products;

    public TablesCache GetTablesCache() => _tables;

    public WaitersCache GetWaitersCache() => _waiters;

    public LicenseOperation LicenseOperation() => new(_licenses, _waiters);

    public OrderOperation OrderOperation() => new(_licenses, _waiters, _tables, _orders);
}