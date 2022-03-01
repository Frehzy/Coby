using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations.OrderOperation;

public class OrderOperation : IOrderOperation
{
    public AllCache Cache { get; set; }

    public Order CreateOrder(Credentials credentials, Waiter waiter, Table table)
    {
        if (Helper.CheckLicense(Cache, credentials) is null)
            throw new EntityNotFound(credentials.WaiterId);

        return Cache.OrdersCache.AddOrder(new Order(Guid.NewGuid(), table, waiter));
    }

    public Order GetOrderById(Credentials credentials, Guid orderId)
    {
        if (Helper.CheckLicense(Cache, credentials) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        return orderOnCache;
    }

    public bool RemoveOrder(Credentials credentials, Guid orderId)
    {
        if (Helper.CheckLicense(Cache, credentials) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        return Cache.OrdersCache.RemoveOrder(orderId);
    }
}