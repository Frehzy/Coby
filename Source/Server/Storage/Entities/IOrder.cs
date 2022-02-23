using System;
using System.Collections.Generic;

namespace Storage.Entities;

public interface IOrder
{
    Guid Id { get; }

    ITable TableId { get; }

    IWaiter Waiter { get; }

    decimal Sum { get; }

    IReadOnlyList<IGuest> Guests { get; }
}