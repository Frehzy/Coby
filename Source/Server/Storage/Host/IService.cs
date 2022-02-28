using Storage.Cache;
using Storage.Operations.LicenseOperation;
using Storage.Operations.NomenclatureOperation;
using Storage.Operations.OrderOperation;
using Storage.Operations.PaymentOperation;
using Storage.Operations.ProductOperation;
using Storage.Operations.TableOperation;
using Storage.Operations.WaiterOperation;
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
    ProductOperation GetProductOperation(AllCache cache);

    [OperationContract]
    WaiterOperation GetWaiterOperation(AllCache cache);

    [OperationContract]
    PaymentOperation GetPaymentOperation(AllCache cache);

    [OperationContract]
    NomenclatureOperation GetNomenclatureOperation(AllCache cache);

    [OperationContract]
    void SetCache();

    [OperationContract]
    void LoadClosedOrderOnDB();
}