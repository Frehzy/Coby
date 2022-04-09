using Shared.Dto.Enities;
using Storage.Cache;
using Storage.Host;
using Storage.Operations;
using Storage.Operations.CreateRemove;
using Storage.Operations.GetBy;
using Storage.Operations.OrderOperation;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Coby.ClientOperation;

public class Client : IClient
{
    private readonly IService _service;
    public delegate Task<Request> CloseCafeShiftDelegate(Credentials credentials, CashRegister cashRegister);

    public LicenseOperation LicenseOperation { get; }

    public TableOperation TableOperation { get; }

    public WaiterOperation WaiterOperation { get; }

    public OrderOperation OrderOperation { get; }

    public GetByCache GetByCacheOperation { get; }

    public Creater Creater { get; }

    public CloseCafeShiftDelegate CloseCafeShift { get; }

    public Client()
    {
        _service = CreateClient();
        CloseCafeShift = _service.CloseCafeShift;
        AllCache cache = new(_service);
        GetByCacheOperation = new(cache);
        LicenseOperation = _service.GetLicenseOperation(cache);
        LicenseOperation.Cache = cache;
        TableOperation = _service.GetTableOperation(cache);
        TableOperation.Cache = cache;
        WaiterOperation = _service.GetWaiterOperation(cache);
        WaiterOperation.Cache = cache;
        OrderOperation = _service.GetOrderOperation(cache);
        OrderOperation.Cache = cache;
        Creater = _service.GetCreater(cache);
        Creater.Cache = cache;
    }

    public IService CreateClient()
    {
        var serviceAddress = "127.0.0.1:10000";
        var serviceName = "CobyServer";

        var tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
        var address = new EndpointAddress(tcpUri);
        var clientBinding = new NetTcpBinding();
        clientBinding.Security.Mode = SecurityMode.None;
        clientBinding.MaxReceivedMessageSize = 2097152;
        clientBinding.MaxBufferPoolSize = 2097152;
        clientBinding.MaxBufferSize = 2097152;
        ChannelFactory<IService> factory = new(clientBinding, address);
        return factory.CreateChannel();
    }
}