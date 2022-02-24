using Storage.Host;
using System;
using System.ServiceModel;

namespace Coby.ClientOperation;

public class Client : IClient
{
    private readonly IService _service;

    public ClientInstance ClientInstance { get; }

    public Client()
    {
        _service = CreateClient();
        ClientInstance = _service.GetClient();
    }

    public IService CreateClient()
    {
        var serviceAddress = "127.0.0.1:10000";
        var serviceName = "CobyServer";

        var tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
        var address = new EndpointAddress(tcpUri);
        var clientBinding = new NetTcpBinding();
        clientBinding.Security.Mode = SecurityMode.None;
        ChannelFactory<IService> factory = new(clientBinding, address);
        return factory.CreateChannel();
    }
}