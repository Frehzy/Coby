using Shared.Dto.Enities;
using Storage.Cache;
using Storage.Host;
using Storage.Operations;
using Storage.Operations.CreateRemove;
using Storage.Operations.GetBy;
using Storage.Operations.OrderOperation;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Office.ClientOperation;

public class Client : IClient
{
    private readonly IService _service;
    public delegate List<Order> GetCloseOrdersDelegate();

    public LicenseOperation LicenseOperation { get; }

    public TableOperation TableOperation { get; }

    public WaiterOperation WaiterOperation { get; }

    public OrderOperation OrderOperation { get; }

    public GetByCache GetByCacheOperation { get; }

    public Creater Creater { get; }

    public Remover Remover { get; }

    public AllCache AllCache { get; }

    public GetCloseOrdersDelegate GetCloseOrders { get; }

    public Client()
    {
        _service = CreateClient();
        AllCache = new(_service);
        GetByCacheOperation = new(AllCache);
        LicenseOperation = _service.GetLicenseOperation(AllCache);
        LicenseOperation.Cache = AllCache;
        TableOperation = _service.GetTableOperation(AllCache);
        TableOperation.Cache = AllCache;
        WaiterOperation = _service.GetWaiterOperation(AllCache);
        WaiterOperation.Cache = AllCache;
        OrderOperation = _service.GetOrderOperation(AllCache);
        OrderOperation.Cache = AllCache;
        Creater = _service.GetCreater(AllCache);
        Creater.Cache = AllCache;
        Remover = _service.GetRemover(AllCache);
        Remover.Cache = AllCache;
        GetCloseOrders = _service.GetCloseOrders;
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