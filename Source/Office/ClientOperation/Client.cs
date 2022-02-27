using Storage.Cache;
using Storage.Host;
using Storage.Operations.LicenseOperation;
using Storage.Operations.OrderOperation;
using System;
using System.ServiceModel;

namespace Office.ClientOperation;

public class Client : IClient
{
    private readonly IService _service;

    public LicenseOperation LicenseOperation { get; }

    public OrderOperation OrderOperation { get; }

    public AllCache AllCache { get; }

    public ILicenseCache LicensesCache { get; }

    public IOrderCache OrdersCache { get; }

    public IPaymentTypeCache PaymentTypesCache { get; }

    public IProductCache ProductsCache { get; }

    public ITableCache TablesCache { get; }

    public IWaiterCache WaitersCache { get; }

    public Client()
    {
        _service = CreateClient();
        LicensesCache = _service;
        OrdersCache = _service;
        PaymentTypesCache = _service;
        ProductsCache = _service;
        TablesCache = _service;
        WaitersCache = _service;
        AllCache = new(_service);
        LicenseOperation = _service.GetLicenseOperation(AllCache);
        OrderOperation = _service.GetOrderOperation(AllCache);
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