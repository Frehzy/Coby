using Shared;
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
        if (Helper.WaiterById(Cache, waiterId, out var waiter) is null)
            throw new EntityNotFoundException(waiterId, typeof(Waiter));

        Cache.LicensesCache.AddLicense(new License(waiterId));
        Log.Info($"{nameof(Waiter)} open personal shift. {Log.SerializeInstance(waiter)}");
        return Cache.WaitersCache.ChangeWaiterStatus(waiterId, WaiterSessionStatus.Open);
    }

    public Waiter ClosePersonalShift(Guid waiterId)
    {
        if (Helper.WaiterById(Cache, waiterId, out var waiter) is null)
            throw new EntityNotFoundException(waiterId, typeof(Waiter));

        Cache.LicensesCache.RemoveLicense(waiterId);
        Log.Info($"{nameof(Waiter)} close personal shift. {Log.SerializeInstance(waiter)}");
        return Cache.WaitersCache.ChangeWaiterStatus(waiterId, WaiterSessionStatus.Closed);
    }
}