using Storage.Cache;
using Storage.Host;
using Storage.Operations.LicenseOperation;
using Storage.Operations.OrderOperation;

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

    LicenseOperation LicenseOperation { get; }

    OrderOperation OrderOperation { get; }

    IService CreateClient();
}