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
            Payment = order.Payment.Select(x => PaymentFactory.CreateDto(x.Value)).ToDictionary(x => x.Id, x => x),
            Sum = order.Sum,
            StartTime = order.StartTime,
            EndTime = order.EndTime,
            Guests = order.Guests.Select(x => GuestFactory.CreateDto(x.Value)).ToDictionary(x => x.Id, x => x),
            OrderStatus = order.OrderStatus
        };
    }

    public static Order Create(OrderDto orderDto) =>
        new(orderDto.Id,
            TableFactory.Create(orderDto.Table),
            WaiterFactory.Create(orderDto.Waiter),
            orderDto.Sum,
            orderDto.Payment.Select(x => PaymentFactory.Create(x.Value)).ToList(),
            orderDto.Guests.Select(x => GuestFactory.Create(x.Value)).ToList(),
            orderDto.OrderStatus,
            orderDto.StartTime,
            orderDto.EndTime);
}