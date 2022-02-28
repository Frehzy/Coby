using Storage.Cache;
using Storage.Host;
using Storage.Operations.LicenseOperation;
using Storage.Operations.NomenclatureOperation;
using Storage.Operations.OrderOperation;
using Storage.Operations.PaymentOperation;
using Storage.Operations.ProductOperation;
using Storage.Operations.TableOperation;
using Storage.Operations.WaiterOperation;
using System;
using System.ServiceModel;

namespace Office.ClientOperation;

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

    public AllCache AllCache { get; }

    public ILicenseCache LicensesCache { get; }

    public IOrderCache OrdersCache { get; }

    public IPaymentTypeCache PaymentTypesCache { get; }

    public IProductCache ProductsCache { get; }

    public ITableCache TablesCache { get; }

    public IWaiterCache WaitersCache { get; }

    public INomenclatureCache NomenclatureCache { get; }

    public Client()
    {
        _service = CreateClient();
        LicensesCache = _service;
        OrdersCache = _service;
        PaymentTypesCache = _service;
        ProductsCache = _service;
        TablesCache = _service;
        WaitersCache = _service;
        NomenclatureCache = _service;
        AllCache = new(_service);
        LicenseOperation = _service.GetLicenseOperation(AllCache);
        LicenseOperation.Cache = AllCache;
        OrderOperation = _service.GetOrderOperation(AllCache);
        OrderOperation.Cache = AllCache;
        TableOperation = _service.GetTableOperation(AllCache);
        TableOperation.Cache = AllCache;
        ProductOperation = _service.GetProductOperation(AllCache);
        ProductOperation.Cache = AllCache;
        WaiterOperation = _service.GetWaiterOperation(AllCache);
        WaiterOperation.Cache = AllCache;
        PaymentOperation = _service.GetPaymentOperation(AllCache);
        PaymentOperation.Cache = AllCache;
        NomenclatureOperation = _service.GetNomenclatureOperation(AllCache);
        NomenclatureOperation.Cache = AllCache;
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