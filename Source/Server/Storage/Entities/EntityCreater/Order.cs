using Storage.Enums;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.EntityCreater;

internal class Order : IOrder
{
    private readonly ConcurrentDictionary<Guid, IGuest> _guests = new();

    public Guid Id { get; }

    public ITable Table { get; }

    public IWaiter Waiter { get; }

    public OrderStatus OrderStatus { get; }

    public decimal Sum { get; private set; }

    public IReadOnlyList<IGuest> Guests => _guests.Values.ToList();

    public Order(ITable table, IWaiter waiter, OrderStatus orderStatus)
    {
        Id = Guid.NewGuid();
        Table = table;
        Waiter = waiter;
        OrderStatus = orderStatus;
    }

    public void ChangeSum(decimal sum) => Sum = sum;

    public IGuest AddGuest(IGuest guest) =>
        _guests.TryAdd(guest.Id, guest)
        ? guest
        : throw new OverflowException($"An element with the same Guid [{guest.Id}] already exists.");

    public void RemoveGuestById(Guid guestId)
    {
        if (_guests.TryRemove(guestId, out _) is false)
            throw new EntityNotFound(guestId);
    }
}