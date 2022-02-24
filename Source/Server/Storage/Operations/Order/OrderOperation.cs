using Storage.Cache;
using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using EntityOrder = Storage.Entities.Implementation.Order;

namespace Storage.Operations.Order;

public class OrderOperation : IOrderOperation
{
    public AllCache Cache { get; }

    public OrderOperation(AllCache cache) =>
        Cache = cache;

    public IOrder CreateOrder(ICredentials credentials, IWaiter waiter, ITable table)
    {
        if (Cache.Licenses.TryFind(credentials.WaiterId) is null)
            throw new EntityNotFound(credentials.WaiterId);

        var order = new EntityOrder(Guid.NewGuid(), table, waiter);
        return Cache.Orders.TryAdd(order);
    }
}