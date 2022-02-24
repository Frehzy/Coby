using Shared.Exceptions;
using Storage.Entities.Implementation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache;

public class LicensesCache
{
    private readonly ConcurrentDictionary<Guid, License> _licenses = new();

    public IReadOnlyList<License> Licenses => _licenses.Values.ToList();

    public License TryAdd(License license) =>
        _licenses.TryAdd(license.WaiterId, license)
        ? license
        : throw new OverflowException($"An element with the same Guid [{license.WaiterId}] already exists.");

    public License TryFind(Guid waiterId) =>
        _licenses.TryGetValue(waiterId, out var license)
            ? license : default;

    public void TryRemove(Guid waiterId)
    {
        if (_licenses.TryRemove(waiterId, out _) is false)
            throw new EntityNotFound(waiterId);
    }
}