using System;

namespace Storage.Entities.EntityCreater;

public class Product : IProduct
{
    public Guid Id { get; }

    public string ProductName { get; }

    public decimal Price { get; }

    public Product(Guid id, string productName, decimal price)
    {
        Id = id;
        ProductName = productName;
        Price = price;
    }
}