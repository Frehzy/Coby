﻿using Storage.Cache;
using Storage.Host;
using Storage.Operations;
using Storage.Operations.CreateRemove;
using Storage.Operations.GetBy;
using Storage.Operations.OrderOperation;
using static Office.ClientOperation.Client;

namespace Office.ClientOperation;

public interface IClient
{
    AllCache AllCache { get; }

    LicenseOperation LicenseOperation { get; }

    Creater Creater { get; }

    Remover Remover { get; }

    TableOperation TableOperation { get; }

    WaiterOperation WaiterOperation { get; }

    OrderOperation OrderOperation { get; }

    GetByCache GetByCacheOperation { get; }

    GetCloseOrdersDelegate GetCloseOrders { get; }

    IService CreateClient();
}