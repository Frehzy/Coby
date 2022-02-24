using System;

namespace Shared.Dto;

public class ProductDto
{
    public Guid Id { get; }

    public string ProductName { get; }

    public decimal Price { get; }

    public ProductDto(Guid id, string productName, decimal price)
    {
        Id = id;
        ProductName = productName;
        Price = price;
    }
}