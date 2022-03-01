using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.OrderOperation;

public class OrderOperation : IOrderOperation
{
    public AllCache Cache { get; set; }

    public Order CreateOrder(Credentials credentials, Table table)
    {
        if (Helper.CheckLicense(Cache, credentials) is null)
            throw new EntityNotFound(credentials.WaiterId);

        Helper.WaiterById(Cache, credentials.WaiterId, out Waiter waiterOnCache);
        return Cache.OrdersCache.AddOrder(new Order(Guid.NewGuid(), table, waiterOnCache));
    }

    public Order GetOrderById(Credentials credentials, Guid orderId)
    {
        if (Helper.CheckLicense(Cache, credentials) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        return orderOnCache;
    }

    public List<Order> GetOrders() =>
        Cache.OrdersCache.GetOrdersCache();

    public bool RemoveOrder(Credentials credentials, Guid orderId)
    {
        if (Helper.CheckLicense(Cache, credentials) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        return Cache.OrdersCache.RemoveOrder(orderId);
    }
}