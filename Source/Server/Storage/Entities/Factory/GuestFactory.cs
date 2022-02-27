using Shared.Dto.Enities;
using Storage.Entities.Implementation;
using System.Linq;

namespace Storage.Entities.Factory;

internal static class GuestFactory
{
    public static GuestDto CreateDto(Guest guest) =>
        new()
        {
            Id = guest.Id,
            Name = guest.Name,
            Products = guest.Products.Select(x => ProductFactory.CreateDto(x)).ToList()
        };

    public static Guest Create(GuestDto guestDto) =>
        new(guestDto.Id,
            guestDto.Name,
            guestDto.Products.Select(x => ProductFactory.Create(x)).ToList());
}
