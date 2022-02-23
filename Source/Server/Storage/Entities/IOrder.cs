using Storage.Enums;
using System;
using System.Collections.Generic;

namespace Storage.Entities;

public interface IOrder
{
    Guid Id { get; }

    ITable Table { get; }

    IWaiter Waiter { get; }

    decimal Sum { get; }

    IReadOnlyList<IGuest> Guests { get; }

    OrderStatus OrderStatus { get; }

    void ChangeSum(decimal sum);

    IGuest AddGuest(IGuest guest);

    void RemoveGuestById(Guid guestId);
}