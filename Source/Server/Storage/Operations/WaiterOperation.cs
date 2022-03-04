using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations;

public class WaiterOperation
{
    public AllCache Cache { get; set; }

    public Waiter OpenPersonalShift(Guid waiterId)
    {
        if (Helper.WaiterById(Cache, waiterId, out _) is null)
            throw new EntityNotFound(waiterId);

        Cache.LicensesCache.AddLicense(new License(waiterId));
        return Cache.WaitersCache.ChangeWaiterStatus(waiterId, WaiterSessionStatus.Open);
    }

    public Waiter ClosePersonalShift(Guid waiterId)
    {
        if (Helper.WaiterById(Cache, waiterId, out _) is null)
            throw new EntityNotFound(waiterId);

        Cache.LicensesCache.RemoveLicense(waiterId);
        return Cache.WaitersCache.ChangeWaiterStatus(waiterId, WaiterSessionStatus.Closed);
    }
}