﻿#nullable enable

using Storage.Entities;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Waiters;

public interface IWaitersCache
{
    IReadOnlyList<IWaiter> Waiters { get; }

    IWaiter TryAdd(IWaiter waiter);

    void TryRemove(Guid waiterId);

    IWaiter? TryFind(Guid waiterId);
}