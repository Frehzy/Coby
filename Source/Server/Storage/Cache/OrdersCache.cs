using Shared.Entities.Dto;
using Shared.Exceptions;
using Storage.Entities.ConverterToDto;
using Storage.Entities.Implementation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache;

public class OrdersCache
{
    private readonly ConcurrentDictionary<Guid, Order> _orders = new();

    public IReadOnlyList<OrderDto> Orders => _orders.Values.Select(x => new ToOrderDto(x).Convert()).ToList();

    public Order TryAdd(Order order)
    {
        var result = _orders.TryAdd(order.Id, order)
            ? order
            : throw new OverflowException($"An element with the same Guid [{order.Id}] already exists.");
        return result;
    }

    public Order TryFind(Guid orderId) =>
        _orders.TryGetValue(orderId, out var license)
            ? license : default;

    public void TryRemove(Guid orderId)
    {
        if (_orders.TryRemove(orderId, out _) is false)
            throw new EntityNotFound(orderId);
    }
}