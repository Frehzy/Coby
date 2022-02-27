using System;

namespace Storage.Entities.Implementation;

public class Product
{
    public Guid Id { get; set; }

    public string ProductName { get; set; }

    public decimal Price { get; set; }

    public bool IsItForSale { get; set; }

    public Product() { }

    public Product(Guid productId, string productName, decimal price, bool isItForSale)
    {
        Id = productId;
        ProductName = productName;
        Price = price;
        IsItForSale = isItForSale;
    }
}