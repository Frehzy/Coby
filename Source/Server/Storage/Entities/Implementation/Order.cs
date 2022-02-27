using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.Implementation;

public class Order
{
    private readonly ConcurrentDictionary<Guid, Guest> _guests = new();
    private readonly ConcurrentDictionary<Guid, Payment> _paymentTypes = new();

    public Guid Id { get; }

    public Table Table { get; }

    public Waiter Waiter { get; }

    public decimal Sum { get; private set; }

    public IReadOnlyCollection<Payment> Payment => _paymentTypes.Values.ToList();

    public IReadOnlyCollection<Guest> Guests => _guests.Values.ToList();

    public OrderStatus OrderStatus { get; }

    public DateTime StartTime { get; }

    public DateTime? EndTime { get; }

    public Order() { }

    public Order(Guid orderId, Table table, Waiter waiter)
    {
        Id = orderId;
        Table = table;
        Waiter = waiter;
        OrderStatus = OrderStatus.New;
        StartTime = DateTime.Now;
    }

    public Order(Guid orderId, Table table, Waiter waiter, decimal sum, List<Payment> payments, List<Guest> guests, OrderStatus status, DateTime startTime, DateTime? endTime = default)
    {
        Id = orderId;
        Table = table;
        Waiter = waiter;
        Sum = sum;
        payments.ForEach(x => _paymentTypes.TryAdd(x.Id, x));
        guests.ForEach(x => _guests.TryAdd(x.Id, x));
        OrderStatus = status;
        StartTime = startTime;
        EndTime = endTime;
    }

    public void ChangeSum(decimal sum) => Sum = sum;

    public Guest TryAddGuest(Guest guest) =>
        _guests.TryAdd(guest.Id, guest)
            ? guest
            : throw new OverflowException($"An element with the same Guid [{guest.Id}] already exists.");

    public void RemoveGuestById(Guid guestId)
    {
        if (_guests.TryRemove(guestId, out _) is false)
            throw new EntityNotFound(guestId);
    }

    public Payment TryAddPayment(Payment payment) =>
        _paymentTypes.TryAdd(payment.Id, payment)
            ? payment
            : throw new OverflowException($"An element with the same Guid [{payment.Id}] already exists.");

    public void RemovePayment(Guid paymentId)
    {
        if (_paymentTypes.TryRemove(paymentId, out _) is false)
            throw new EntityNotFound(paymentId);
    }
}