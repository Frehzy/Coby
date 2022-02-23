using Storage.Entities;
using System;
using System.Collections.Generic;

namespace Storage.Cache.License;

public interface ILicensesCache
{
    IReadOnlyCollection<ILicense> Licenses { get; }

    ILicense TryAdd(ILicense license);

    void TryRemove(Guid waiterId);

    ILicense? TryFind(Guid waiterId);
}