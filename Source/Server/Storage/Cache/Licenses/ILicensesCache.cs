using Storage.Entities.Interface;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Licenses;

public interface ILicensesCache
{
    public IReadOnlyCollection<ILicense> Licenses { get; }

    public ILicense TryAdd(ILicense license);

    public ILicense TryFind(Guid waiterId);

    public void TryRemove(Guid waiterId);
}