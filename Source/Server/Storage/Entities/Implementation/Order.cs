using Shared.Entities.Enums;
using Shared.Exceptions;
using Storage.Entities.Interface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.Implementation;

public class Order : IOrder
{
    private readonly ConcurrentDictionary<Guid, IGuest> _guests = new();

    public Guid Id { get; }

    public ITable Table { get; }

    public IWaiter Waiter { get; }

    public decimal Sum { get; private set; }

    public IReadOnlyCollection<IGuest> Guests => _guests.Values.ToList();

    public OrderStatus OrderStatus { get; }

    public DateTime StartTime { get; }

    public DateTime? EndTime { get; }

    public IGuest TryAddGuest(IGuest guest)
    {
        var result = _guests.TryAdd(guest.Id, guest)
            ? guest
            : throw new OverflowException($"An element with the same Guid [{guest.Id}] already exists.");
        return result;
    }

    public void ChangeSum(decimal sum) => Sum = sum;

    public void RemoveGuestById(Guid guestId)
    {
        if (_guests.TryRemove(guestId, out _) is false)
            throw new EntityNotFound(guestId);
    }

    public Order(Guid orderId, ITable table, IWaiter waiter)
    {
        Id = orderId;
        Table = table;
        Waiter = waiter;
        OrderStatus = OrderStatus.New;
        StartTime = DateTime.Now;
    }
}