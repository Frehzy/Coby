using Storage.Entities.Interface;
using Storage.Enums;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.Implementation;

public class Order : IOrder
{
    private readonly ConcurrentDictionary<Guid, IGuest> _guests = new();
    private readonly ConcurrentDictionary<Guid, IPayment> _paymentTypes = new();

    public Guid Id { get; }

    public ITable Table { get; }

    public IWaiter Waiter { get; }

    public decimal Sum { get; private set; }

    public IReadOnlyCollection<IPayment> Payment => _paymentTypes.Values.ToList();

    public IReadOnlyCollection<IGuest> Guests => _guests.Values.ToList();

    public OrderStatus OrderStatus { get; }

    public DateTime StartTime { get; }

    public DateTime? EndTime { get; }

    public Order(Guid orderId, ITable table, IWaiter waiter)
    {
        Id = orderId;
        Table = table;
        Waiter = waiter;
        OrderStatus = OrderStatus.New;
        StartTime = DateTime.Now;
    }

    public void ChangeSum(decimal sum) => Sum = sum;

    public IGuest TryAddGuest(IGuest guest) =>
        _guests.TryAdd(guest.Id, guest)
            ? guest
            : throw new OverflowException($"An element with the same Guid [{guest.Id}] already exists.");

    public void RemoveGuestById(Guid guestId)
    {
        if (_guests.TryRemove(guestId, out _) is false)
            throw new EntityNotFound(guestId);
    }

    public IPayment TryAddPayment(IPayment payment) =>
        _paymentTypes.TryAdd(payment.Id, payment)
            ? payment
            : throw new OverflowException($"An element with the same Guid [{payment.Id}] already exists.");

    public void RemovePayment(Guid paymentId)
    {
        if (_paymentTypes.TryRemove(paymentId, out _) is false)
            throw new EntityNotFound(paymentId);
    }
}