using Shared.Dto.Enities;
using Storage.Entities.Implementation;
using System.Linq;

namespace Storage.Entities.Factory;

internal static class OrderFactory
{
    public static OrderDto CreateDto(Order order)
    {
        return new()
        {
            Id = order.Id,
            Table = TableFactory.CreateDto(order.Table),
            Waiter = WaiterFactory.CreateDto(order.Waiter),
            Payment = order.Payment.Select(x => PaymentFactory.CreateDto(x)).ToList(),
            Sum = order.Sum,
            StartTime = order.StartTime,
            EndTime = order.EndTime,
            Guests = order.Guests.Select(x => GuestFactory.CreateDto(x)).ToList(),
            OrderStatus = order.OrderStatus
        };
    }

    public static Order Create(OrderDto orderDto) =>
        new(orderDto.Id,
            TableFactory.Create(orderDto.Table),
            WaiterFactory.Create(orderDto.Waiter),
            orderDto.Sum,
            orderDto.Payment.Select(x => PaymentFactory.Create(x)).ToList(),
            orderDto.Guests.Select(x => GuestFactory.Create(x)).ToList(),
            orderDto.OrderStatus,
            orderDto.StartTime,
            orderDto.EndTime);
}