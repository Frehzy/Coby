using Storage.Host;
using Storage.Operations;
using Storage.Operations.CreateRemove;
using Storage.Operations.GetBy;
using Storage.Operations.OrderOperation;
using static Coby.ClientOperation.Client;

namespace Coby.ClientOperation;

public interface IClient
{
    LicenseOperation LicenseOperation { get; }

    Creater Creater { get; }

    TableOperation TableOperation { get; }

    WaiterOperation WaiterOperation { get; }

    OrderOperation OrderOperation { get; }

    GetByCache GetByCacheOperation { get; }

    CloseCafeShiftDelegate CloseCafeShift { get; }

    IService CreateClient();
}