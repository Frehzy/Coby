using Shared.Dto;
using Shared.Entities.Dto;
using Storage.Entities.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.ConverterToDto;

internal class ToGuestDto
{
    private readonly List<IGuest> _guests = new();

    public IReadOnlyCollection<IGuest> Guests => _guests;

    public ToGuestDto(IReadOnlyCollection<IGuest> guests) =>
        _guests.AddRange(guests);

    public IReadOnlyList<GuestDto> Convert() =>
        _guests.Select(x => new GuestDto(x.Id,
                                         x.Name,
                                         ConvertToProductDto(x.Products))).ToList();

    private IReadOnlyList<ProductDto> ConvertToProductDto(IReadOnlyCollection<IProduct> products)
    {
        var result = new List<ProductDto>();
        result.AddRange(products.Select(x => new ToProductDto(x).Convert()));
        return result;
    }
}