using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache.Waiters;

public class WaitersCache : IWaitersCache
{
    private readonly ConcurrentDictionary<Guid, IWaiter> _waiters = new();

    public IReadOnlyCollection<IWaiter> Waiters => _waiters.Values.ToList();

    public IWaiter TryAdd(IWaiter waiter) =>
        _waiters.TryAdd(waiter.Id, waiter)
        ? waiter
        : throw new OverflowException($"An element with the same Guid [{waiter.Id}] already exists.");

    public IWaiter TryFind(Guid waiterId) =>
        _waiters.TryGetValue(waiterId, out var license)
            ? license : default;

    public void TryRemove(Guid waiterId)
    {
        if (_waiters.TryRemove(waiterId, out _) is false)
            throw new EntityNotFound(waiterId);
    }
}