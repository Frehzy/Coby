using Shared.Entities.Dto;
using Storage.Entities.Interface;

namespace Storage.Entities.ConverterToDto;

internal class ToOrderDto
{
    public IOrder Order { get; }

    public ToOrderDto(IOrder order)
    {
        Order = order;
    }

    public OrderDto Convert() =>
        new(Order.Id,
            new ToTableDto(Order.Table).Convert(),
            new ToWaiterDto(Order.Waiter).Convert(),
            Order.Sum,
            new ToGuestDto(Order.Guests).Convert(),
            Order.OrderStatus);
}