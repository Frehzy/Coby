﻿using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache.Licenses;

public class LicensesCache : ILicensesCache
{
    private readonly ConcurrentDictionary<Guid, ILicense> _licenses = new();

    public IReadOnlyCollection<ILicense> Licenses => _licenses.Values.ToList();

    public ILicense TryAdd(ILicense license) =>
        _licenses.TryAdd(license.WaiterId, license)
        ? license
        : throw new OverflowException($"An element with the same Guid [{license.WaiterId}] already exists.");

    public ILicense TryFind(Guid waiterId) =>
        _licenses.TryGetValue(waiterId, out var license)
            ? license : default;

    public void TryRemove(Guid waiterId)
    {
        if (_licenses.TryRemove(waiterId, out _) is false)
            throw new EntityNotFound(waiterId);
    }
}