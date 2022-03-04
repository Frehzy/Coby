using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using System;

namespace Storage.Operations.OrderOperation;

public class GuestOperations
{
    public Order Order { get; }

    public GuestOperations(Order order) =>
        Order = order;

    public Guest AddGuestOnOrder()
    {
        var guestCount = Order.GetGuests().Count;
        var guest = new Guest(Guid.NewGuid(), $"Гость {guestCount++}");
        Order.Guests.Add(guest.Id, guest);
        return guest;
    }

    public void RemoveGuestOnOrderById(Guid guestId)
    {
        if (Order.Guests.Remove(guestId) is false)
            throw new EntityNotFound(guestId);
    }
}