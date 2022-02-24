using Storage.Entities.Interface;
using System;

namespace Storage.Entities.Implementation;

public class Product : IProduct
{
    public Guid Id { get; }

    public string ProductName { get; }

    public decimal Price { get; }

    public Product(Guid productId, string productName, decimal price)
    {
        Id = productId;
        ProductName = productName;
        Price = price;
    }
}