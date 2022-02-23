using Storage.Cache.License;
using Storage.Cache.Order;
using Storage.Cache.Product;
using Storage.Cache.Table;
using Storage.Cache.Waiters;
using Storage.Operations;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract(CallbackContract = typeof(IServerCallback))]
public interface IService
{
    IOrdersCache Orders { get; }

    IProductsCache Products { get; }

    IWaitersCache Waiters { get; }

    ILicensesCache Licenses { get; }

    ITablesCache Tables { get; }

    ILicenseOperation LicenseOperation { get; }

    IOrderOperation OrderOperation { get; }
}