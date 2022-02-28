#nullable enable

using Shared.Dto.Enums;
using System;
using System.Collections.Generic;

namespace Shared.Dto.Enities;

public class Order
{
    public Guid Id { get; set; }

    public Table Table { get; set; }

    public Waiter Waiter { get; set; }

    public decimal Sum { get; set; }

    public Dictionary<Guid, Payment>? Payment { get; set; }

    public Dictionary<Guid, Guest>? Guests { get; set; }

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

    public void ChangeSum(decimal sum) => Sum = sum;
}