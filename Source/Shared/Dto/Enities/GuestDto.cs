using System;
using System.Collections.Generic;

namespace Shared.Dto.Enities;

public record GuestDto
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public IReadOnlyCollection<ProductDto> Products { get; init; }

    public GuestDto() { }

    public GuestDto(Guid guestId, string name, List<ProductDto> products)
    {
        Id = guestId;
        Name = name;
        Products = products;
    }
}