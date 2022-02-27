using Shared.Dto.Enums;
using System;
using System.Collections.Generic;

namespace Shared.Dto.Enities;

public class OrderDto
{
    public Guid Id { get; init; }

    public TableDto Table { get; init; }

    public WaiterDto Waiter { get; init; }

    public decimal Sum { get; init; }

    public IReadOnlyCollection<PaymentDto> Payment { get; init; }

    public IReadOnlyCollection<GuestDto> Guests { get; init; }

    public OrderStatus OrderStatus { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public OrderDto() { }

    public OrderDto(Guid id,
                    TableDto table,
                    WaiterDto waiter,
                    decimal sum,
                    List<PaymentDto> paymentDtos,
                    List<GuestDto> guestDtos,
                    OrderStatus status,
                    DateTime startTime,
                    DateTime endTime)
    {
        Id = id;
        Table = table;
        Waiter = waiter;
        Sum = sum;
        Payment = paymentDtos;
        Guests = guestDtos;
        OrderStatus = status;
        StartTime = startTime;
        EndTime = endTime;
    }
}