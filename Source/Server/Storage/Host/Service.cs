using System.ServiceModel;

namespace Storage.Host;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    private readonly ClientInstance _client;

    public Service() =>
        _client = new();

    public ClientInstance GetClient() => _client;
}