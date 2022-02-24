using Storage.Cache;
using Storage.Operations.Implementation;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract(CallbackContract = typeof(IServerCallback))]
public interface IService
{
    [OperationContract]
    OrdersCache GetOrdersCache();

    [OperationContract]
    ProductsCache GetProductsCache();

    [OperationContract]
    WaitersCache GetWaitersCache();

    [OperationContract]
    LicensesCache GetLicensesCache();

    [OperationContract]
    TablesCache GetTablesCache();

    [OperationContract]
    LicenseOperation LicenseOperation();

    [OperationContract]
    OrderOperation OrderOperation();
}