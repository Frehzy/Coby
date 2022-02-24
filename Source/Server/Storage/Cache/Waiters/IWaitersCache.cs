using Storage.Entities.Interface;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Waiters;

public interface IWaitersCache
{
    public IReadOnlyCollection<IWaiter> Waiters { get; }

    public IWaiter TryAdd(IWaiter waiter);

    public IWaiter TryFind(Guid waiterId);

    public void TryRemove(Guid waiterId);
}