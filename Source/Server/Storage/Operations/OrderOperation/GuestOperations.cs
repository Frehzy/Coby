using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using System;
using System.Linq;

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

    public Guest AddGuestOnOrder(Guid guestId, string name)
    {
        if (Order.GetGuests().FirstOrDefault(x => x.Id.Equals(guestId)) is not null)
            throw new EntityAlreadyExistsException(guestId);

        var guest = new Guest(guestId, name);
        Order.Guests.Add(guest.Id, guest);
        return guest;
    }

    public void RemoveGuestOnOrderById(Guid guestId)
    {
        if (Order.Guests.Remove(guestId) is false)
            throw new EntityNotFound(guestId);
    }
}