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

    public IOrdersCache Orders => _orders;

    public IProductsCache Products => _products;

    public IWaitersCache Waiters => _waiters;

    public ILicensesCache Licenses => _licenses;

    public ITablesCache Tables => _tables;

    public ILicenseOperation LicenseOperation => new LicenseOperation(Licenses, Waiters);

    public IOrderOperation OrderOperation => new OrderOperation(Licenses, Waiters, Tables, Orders);
}