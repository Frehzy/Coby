using Storage.Cache;
using Storage.Host;
using Storage.Operations;

namespace Coby.ClientOperation;

public interface IClient
{
    AllCache Cache { get; }

    AllOperations AllOperations { get; }

    IService CreateClient();
}