using Storage.Entities.Interface;
using System;

namespace Storage.DataBase.ConvertType;

internal class ProductType : IProduct
{
    public Guid Id { get; set; }

    public string ProductName { get; set; }

    public decimal Price { get; set; }

    public ProductType() { }
}