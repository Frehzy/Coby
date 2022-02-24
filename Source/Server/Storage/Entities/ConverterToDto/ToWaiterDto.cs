using Shared.Entities.Dto;
using Storage.Entities.Interface;

namespace Storage.Entities.ConverterToDto;

internal class ToWaiterDto
{
    public IWaiter Waiter { get; }

    public ToWaiterDto(IWaiter waiter) =>
        Waiter = waiter;

    public WaiterDto Convert() =>
        new(Waiter.Id, Waiter.Name, Waiter.Password);
}