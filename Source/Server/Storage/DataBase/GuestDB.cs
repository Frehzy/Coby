using System;

namespace Storage.DataBase;

internal class GuestDB
{
    public Guid OrderId { get; set; }

    public Guid GuestId { get; set; }

    public string Name { get; set; }

    public GuestDB() { }

    public GuestDB(Guid orderId, Guid guestId, string guestName)
    {
        OrderId = orderId;
        GuestId = guestId;
        Name = guestName;
    }
}