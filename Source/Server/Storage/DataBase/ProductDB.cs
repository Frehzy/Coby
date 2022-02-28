using System;

namespace Storage.DataBase;

internal class ProductDB
{
    public Guid OrderId { get; set; }

    public Guid ProductId { get; set; }

    public ProductDB() { }

    public ProductDB(Guid orderId, Guid productID)
    {
        OrderId = orderId;
        ProductId = productID;
    }
}