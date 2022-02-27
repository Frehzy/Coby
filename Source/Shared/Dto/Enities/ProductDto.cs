using System;

namespace Shared.Dto.Enities;

public record ProductDto
{
    public Guid Id { get; init; }

    public string ProductName { get; init; }

    public decimal Price { get; init; }

    public ProductDto() { }

    public ProductDto(Guid productId, string productName, decimal price)
    {
        Id = productId;
        ProductName = productName;
        Price = price;
    }
}