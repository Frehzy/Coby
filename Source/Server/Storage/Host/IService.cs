using Shared.Dto.Enities;
using Storage.Cache;
using Storage.Operations;
using Storage.Operations.CreateRemove;
using Storage.Operations.OrderOperation;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IService : ILicenseCache, IOrderCache, IPaymentTypeCache, IProductCache, ITableCache, IWaiterCache, INomenclatureCache
{
    [OperationContract]
    LicenseOperation GetLicenseOperation(AllCache cache);

    [OperationContract]
    OrderOperation GetOrderOperation(AllCache cache);

    [OperationContract]
    TableOperation GetTableOperation(AllCache cache);

    [OperationContract]
    WaiterOperation GetWaiterOperation(AllCache cache);

    [OperationContract]
    Creater GetCreater(AllCache cache);

    [OperationContract]
    Remover GetRemover(AllCache cache);

    [OperationContract]
    void SetCache();

    [OperationContract]
    void CloseCafeShift(Credentials credentials);
}