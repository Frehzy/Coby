using System;
using System.Collections.Generic;

namespace Shared.Dto.Enities;

public record GuestDto
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public Dictionary<Guid, ProductDto> Products { get; init; }

    public GuestDto() { }

    public GuestDto(Guid guestId, string name, List<ProductDto> products)
    {
        Id = guestId;
        Name = name;
        products.ForEach(x => Products.Add(x.Id, x));
    }
}