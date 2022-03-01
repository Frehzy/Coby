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
using System;
using System.ServiceModel;

namespace Coby.ClientOperation;

public class Client : IClient
{
    private readonly IService _service;

    public LicenseOperation LicenseOperation { get; }

    public OrderOperation OrderOperation { get; }

    public TableOperation TableOperation { get; }

    public ProductOperation ProductOperation { get; }

    public WaiterOperation WaiterOperation { get; }

    public PaymentOperation PaymentOperation { get; }

    public NomenclatureOperation NomenclatureOperation { get; }

    public GuestOperation GuestOperation { get; }

    public Client()
    {
        _service = CreateClient();
        AllCache cache = new(_service);
        LicenseOperation = _service.GetLicenseOperation(cache);
        LicenseOperation.Cache = cache;
        OrderOperation = _service.GetOrderOperation(cache);
        OrderOperation.Cache = cache;
        TableOperation = _service.GetTableOperation(cache);
        TableOperation.Cache = cache;
        ProductOperation = _service.GetProductOperation(cache);
        ProductOperation.Cache = cache;
        WaiterOperation = _service.GetWaiterOperation(cache);
        WaiterOperation.Cache = cache;
        PaymentOperation = _service.GetPaymentOperation(cache);
        PaymentOperation.Cache = cache;
        NomenclatureOperation = _service.GetNomenclatureOperation(cache);
        NomenclatureOperation.Cache = cache;
        GuestOperation = _service.GetGuestOperation(cache);
        GuestOperation.Cache = cache;
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