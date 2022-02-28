using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations.GuestOperation;

public class GuestOperation : IGuestOperation
{
    public AllCache Cache { get; set; }

    public Guest AddGuestOnOrder(Guid orderId)
    {
        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        var guest = new Guest(Guid.NewGuid(), "Гость");
        orderOnCache.Guests.Add(guest.Id, guest);
        return guest;
    }

    public void RemoveGuestOnOrder(Guid orderId, Guid guestId)
    {
        if (Helper.GuestOnOrderById(Cache, orderId, guestId, out Guest guest) is null)
            throw new EntityNotFound(orderId);

        var order = Helper.OrderById(Cache, orderId, out _);
        order.Guests.Remove(guest.Id);
    }
}