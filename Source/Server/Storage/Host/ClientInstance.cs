using Storage.Cache;
using Storage.Operations;

namespace Storage.Host;

public class ClientInstance
{
    public AllCache Cache { get; }

    public AllOperations Operations { get; }

    public ClientInstance()
    {
        Cache = new AllCache();
        Operations = new AllOperations(Cache);
    }
}