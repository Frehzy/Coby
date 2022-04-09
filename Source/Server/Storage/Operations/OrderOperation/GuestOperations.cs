﻿using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations.OrderOperation;

public class GuestOperations
{
    AllCache Cache { get; }

    public Order Order { get; }

    public GuestOperations(AllCache cache, Order order)
    {
        Cache = cache;
        Order = order;
    }

    public Guest AddGuestOnOrder(Credentials credentials)
    {
        if (Helper.CheckLicense(Cache, credentials, out _) is null)
            throw new EntityNotFound(credentials.WaiterId);

        var guestCount = Order.GetGuests().Count;
        var guest = new Guest(Guid.NewGuid(), $"Гость {guestCount++}");
        Order.Guests.Add(guest.Id, guest);
        HistoryHelper.OrderHistory(Order, guest.Id, Entities.Guest, ActionsEnum.Added);
        return guest;
    }

    public Guest AddGuestOnOrder(Credentials credentials, Guid guestId, string name)
    {
        if (Helper.CheckLicense(Cache, credentials, out _) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Order.GetGuests().FirstOrDefault(x => x.Id.Equals(guestId)) is not null)
            throw new EntityAlreadyExistsException(guestId);

        var guest = new Guest(guestId, name);
        Order.Guests.Add(guest.Id, guest);
        return guest;
    }

    public void RemoveGuestOnOrderById(Credentials credentials, Guid guestId)
    {
        if (Helper.CheckLicense(Cache, credentials, out var license) is null)
            throw new EntityNotFound(credentials.WaiterId);

        Cache.DangerousOperationCache.AddDangerousOperations(new(license.Id, $"Remove guest [{guestId}] on order [{Order.Id}]"));
        Order.Guests.Remove(guestId);
        HistoryHelper.OrderHistory(Order, guestId, Entities.Guest, ActionsEnum.Remove);
    }
}