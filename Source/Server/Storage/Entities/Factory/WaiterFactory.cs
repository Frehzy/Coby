using Shared.Dto.Enities;
using Storage.Entities.Implementation;

namespace Storage.Entities.Factory;

internal static class WaiterFactory
{
    public static WaiterDto CreateDto(Waiter waiter) =>
        new()
        {
            Id = waiter.Id,
            Name = waiter.Name,
            Password = waiter.Password,
            Status = waiter.Status
        };

    public static Waiter Create(WaiterDto waiterDto) =>
        new(waiterDto.Id,
            waiterDto.Name,
            waiterDto.Password,
            waiterDto.Status);
}