using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using System;
using System.Collections.Generic;

namespace Storage.Entities.Implementation;

public class Order
{
    public Guid Id { get; set; }

    public Table Table { get; set; }

    public Waiter Waiter { get; set; }

    public decimal Sum { get; set; }

    public Dictionary<Guid, Payment> Payment { get; set; }

    public Dictionary<Guid, Guest> Guests { get; set; }

    public OrderStatus OrderStatus { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

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
        payments.ForEach(x => Payment.Add(x.Id, x));
        guests.ForEach(x => Guests.Add(x.Id, x));
        OrderStatus = status;
        StartTime = startTime;
        EndTime = endTime;
    }

    public void ChangeSum(decimal sum) => Sum = sum;

    public Guest TryAddGuest(Guest guest) =>
        Guests.TryAdd(guest.Id, guest);

    public Guest AddOrUpdate(Guest guest) =>
        Guests.AddOrUpdate(guest.Id, guest);

    public bool RemoveGuestById(Guid guestId) =>
        Guests.TryRemove(guestId) ? true : throw new EntityNotFound(guestId);

    public Payment TryAddPayment(Payment payment) =>
        Payment.TryAdd(payment.Id, payment);

    public Payment AddOrUpdate(Payment payment) =>
        Payment.AddOrUpdate(payment.Id, payment);

    public bool RemovePayment(Guid paymentId) =>
        Payment.TryRemove(paymentId) ? true : throw new EntityNotFound(paymentId);
}