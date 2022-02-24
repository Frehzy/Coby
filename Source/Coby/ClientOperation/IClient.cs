using Storage.Cache;
using Storage.Host;
using Storage.Operations;

namespace Coby.ClientOperation;

public interface IClient
{
    ClientInstance ClientInstance { get; }

    IService CreateClient();
}