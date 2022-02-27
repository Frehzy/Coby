using Storage.Cache;
using Storage.Operations.LicenseOperation;
using Storage.Operations.OrderOperation;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IService : ILicenseCache, IOrderCache, IPaymentTypeCache, IProductCache, ITableCache, IWaiterCache
{
    [OperationContract]
    LicenseOperation GetLicenseOperation(AllCache cache);

    [OperationContract]
    OrderOperation GetOrderOperation(AllCache cache);

    [OperationContract]
    void SetCache();
}