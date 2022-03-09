#nullable enable

using Shared.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared.Dto.Enities;

public class Order
{
    public Guid Id { get; set; }

    public Table Table { get; set; }

    public Waiter Waiter { get; set; }

    public decimal? Sum => Guests?.Values.Select(x => x.Products.Values.Sum(x => x.Price)).Sum();

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
        Payment = new();
        Guests = new();
    }

    public Order(Guid orderId, Table table, Waiter waiter, OrderStatus status, DateTime startTime, DateTime endTime)
    {
        Id = orderId;
        Table = table;
        Waiter = waiter;
        OrderStatus = status;
        StartTime = startTime;
        EndTime = endTime;
        Payment = new();
        Guests = new();
    }

    public List<Payment>? GetPayments() => (Payment?.Values ?? Enumerable.Empty<Payment>()).ToList();

    public List<Guest>? GetGuests() => (Guests?.Values ?? Enumerable.Empty<Guest>()).ToList();
}