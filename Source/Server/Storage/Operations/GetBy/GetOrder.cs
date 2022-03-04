using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetOrder
{
    public AllCache Cache { get; }

    public GetOrder(AllCache cache) =>
        Cache = cache;

    public Order GetOrderById(Guid orderId)
    {
        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        return orderOnCache;
    }

    public List<Order> GetOrders() =>
        Cache.OrdersCache.GetOrdersCache();
}