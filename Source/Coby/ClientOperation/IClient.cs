using Storage.Cache;
using Storage.Host;
using Storage.Operations.GuestOperation;
using Storage.Operations.LicenseOperation;
using Storage.Operations.NomenclatureOperation;
using Storage.Operations.OrderOperation;
using Storage.Operations.PaymentOperation;
using Storage.Operations.ProductOperation;
using Storage.Operations.TableOperation;
using Storage.Operations.WaiterOperation;

namespace Coby.ClientOperation;

public interface IClient
{
    LicenseOperation LicenseOperation { get; }

    OrderOperation OrderOperation { get; }

    TableOperation TableOperation { get; }

    ProductOperation ProductOperation { get; }

    WaiterOperation WaiterOperation { get; }

    PaymentOperation PaymentOperation { get; }

    NomenclatureOperation NomenclatureOperation { get; }

    GuestOperation GuestOperation { get; }

    IService CreateClient();
}