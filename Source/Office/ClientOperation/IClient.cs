using Storage.Cache;
using Storage.Host;
using Storage.Operations.LicenseOperation;
using Storage.Operations.NomenclatureOperation;
using Storage.Operations.OrderOperation;
using Storage.Operations.PaymentOperation;
using Storage.Operations.ProductOperation;
using Storage.Operations.TableOperation;
using Storage.Operations.WaiterOperation;

namespace Office.ClientOperation;

public interface IClient
{
    AllCache AllCache { get; }

    ILicenseCache LicensesCache { get; }

    IOrderCache OrdersCache { get; }

    IPaymentTypeCache PaymentTypesCache { get; }

    IProductCache ProductsCache { get; }

    ITableCache TablesCache { get; }

    IWaiterCache WaitersCache { get; }

    INomenclatureCache NomenclatureCache { get; }

    LicenseOperation LicenseOperation { get; }

    OrderOperation OrderOperation { get; }

    TableOperation TableOperation { get; }

    ProductOperation ProductOperation { get; }

    WaiterOperation WaiterOperation { get; }

    PaymentOperation PaymentOperation { get; }

    NomenclatureOperation NomenclatureOperation { get; }

    IService CreateClient();
}