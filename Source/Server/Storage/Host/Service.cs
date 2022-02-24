using Storage.Cache;
using Storage.Operations;
using System.ServiceModel;

namespace Storage.Host;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    private readonly AllCache _allCache;
    private readonly AllOperations _allOperations;

    public Service()
    {
        _allCache = new();
        _allOperations = new(_allCache);
    }

    public AllCache GetCache() => _allCache;

    public AllOperations GetOperations() => _allOperations;
}