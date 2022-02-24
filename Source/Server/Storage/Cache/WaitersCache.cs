using Shared.Entities.Dto;
using Shared.Exceptions;
using Storage.Entities.ConverterToDto;
using Storage.Entities.Implementation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache;

public class WaitersCache
{
    private readonly ConcurrentDictionary<Guid, Waiter> _waiters = new();

    public IReadOnlyList<WaiterDto> Waiters => _waiters.Values.Select(x => new ToWaiterDto(x).Convert()).ToList();

    public Waiter TryAdd(Waiter waiter) =>
        _waiters.TryAdd(waiter.Id, waiter)
        ? waiter
        : throw new OverflowException($"An element with the same Guid [{waiter.Id}] already exists.");

    public Waiter TryFind(Guid waiterId) =>
        _waiters.TryGetValue(waiterId, out var license)
            ? license : default;

    public void TryRemove(Guid waiterId)
    {
        if (_waiters.TryRemove(waiterId, out _) is false)
            throw new EntityNotFound(waiterId);
    }
}