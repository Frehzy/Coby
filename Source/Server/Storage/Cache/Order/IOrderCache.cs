#nullable enable

using Storage.Entities;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Order;

public interface IOrdersCache
{
    IReadOnlyList<IOrder> Orders { get; }

    IOrder TryAdd(IOrder order);

    void TryRemove(Guid orderId);

    IOrder? TryFind(Guid orderId);
}