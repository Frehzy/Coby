using Shared.Dto;
using System;
using System.Collections.Generic;

namespace Shared.Entities.Dto;

public class GuestDto
{
    public Guid Id { get; }

    public string Name { get; }

    public IReadOnlyList<ProductDto> Products { get; }

    public GuestDto(Guid guestId, string name, IReadOnlyList<ProductDto> products)
    {
        Id = guestId;
        Name = name;
        Products = products;
    }
}
