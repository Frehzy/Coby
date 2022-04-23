using Storage.Host;
using Storage.Operations;
using Storage.Operations.CreateRemove;
using Storage.Operations.GetBy;
using Storage.Operations.OrderOperation;
using static Office.ClientOperation.Client;

namespace Office.ClientOperation;

public interface IClient
{
    LicenseOperation LicenseOperation { get; }

    Creater Creater { get; }

    Remover Remover { get; }

    WaiterOperation WaiterOperation { get; }

    OrderOperation OrderOperation { get; }

    GetByCache GetByCacheOperation { get; }

    DangerousOperation DangerousOperation { get; }

    GetCloseOrdersDelegate GetCloseOrders { get; }

    IService CreateClient();
}