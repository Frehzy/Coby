using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache.Orders;

public class OrdersCache : IOrdersCache
{
    private readonly ConcurrentDictionary<Guid, IOrder> _orders = new();

    public IReadOnlyCollection<IOrder> Orders => _orders.Values.ToList();

    public IOrder TryAdd(IOrder order) =>
        _orders.TryAdd(order.Id, order)
            ? order
            : throw new OverflowException($"An element with the same Guid [{order.Id}] already exists.");

    public IOrder TryFind(Guid orderId) =>
        _orders.TryGetValue(orderId, out var license)
            ? license : default;

    public void TryRemove(Guid orderId)
    {
        if (_orders.TryRemove(orderId, out _) is false)
            throw new EntityNotFound(orderId);
    }
}