using Storage.Entities.Interface;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Orders;

public interface IOrdersCache
{
    public IReadOnlyCollection<IOrder> Orders { get; }

    public IOrder TryAdd(IOrder order);

    public IOrder TryFind(Guid orderId);

    public void TryRemove(Guid orderId);
}