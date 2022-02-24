using Shared.Dto;
using Shared.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Shared.Entities.Dto;

public class OrderDto
{
    public Guid Id { get; }

    public TableDto Table { get; }

    public WaiterDto Waiter { get; }

    public decimal Sum { get; }

    public IReadOnlyList<GuestDto> Guests { get; }

    public OrderStatus OrderStatus { get; }

    public DateTime StartTime { get; }

    public OrderDto(Guid orderId,
                    TableDto table,
                    WaiterDto waiter,
                    decimal sum,
                    IReadOnlyList<GuestDto> guestDto,
                    OrderStatus orderStatus,
                    DateTime startTime)
    {
        Id = orderId;
        Table = table;
        Waiter = waiter;
        Sum = sum;
        Guests = guestDto;
        OrderStatus = orderStatus;
        StartTime = startTime;
    }
}