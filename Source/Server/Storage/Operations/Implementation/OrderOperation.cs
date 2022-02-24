using Shared.Exceptions;
using Storage.Cache;
using Storage.Entities.Implementation;
using Storage.Entities.Interface;
using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Storage.Operations.Implementation;

[DataContract]
public class OrderOperation : IOrderOperation
{
    [DataMember]
    public LicensesCache LicensesCache { get; }

    [DataMember]
    public WaitersCache WaitersCache { get; }

    [DataMember]
    public TablesCache TablesCache { get; }

    [DataMember]
    public OrdersCache OrdersCache { get; }

    public OrderOperation(LicensesCache licensesCache,
                          WaitersCache waitersCache,
                          TablesCache tablesCache,
                          OrdersCache ordersCache)
    {
        LicensesCache = licensesCache;
        WaitersCache = waitersCache;
        TablesCache = tablesCache;
        OrdersCache = ordersCache;
    }

    [OperationContract]
    public IOrder CreateOrder(Credentials credentials, Waiter waiter, Table table)
    {
        if (LicensesCache.TryFind(credentials.WaiterId) is null)
            throw new EntityNotFound(credentials.WaiterId);

        var order = new Order(Guid.NewGuid(), table, waiter);
        return OrdersCache.TryAdd(order);
    }
}