using System;

namespace Storage.DataBase;

internal class ProductDB
{
    public Guid OrderId { get; set; }

    public Guid GuestId { get; set; }

    public Guid ProductId { get; set; }

    public ProductDB() { }

    public ProductDB(Guid orderId, Guid guestId, Guid productID)
    {
        OrderId = orderId;
        GuestId = guestId;
        ProductId = productID;
    }
}