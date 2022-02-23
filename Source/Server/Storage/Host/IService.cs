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
    [OperationContract]
    IOrdersCache GetOrdersCache();

    [OperationContract]
    IProductsCache GetProductsCache();

    [OperationContract]
    IWaitersCache GetWaitersCache();

    [OperationContract]
    ILicensesCache GetLicensesCache();

    [OperationContract]
    ITablesCache GetTablesCache();

    [OperationContract]
    ILicenseOperation LicenseOperation();

    [OperationContract]
    IOrderOperation OrderOperation();
}