using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations.WaiterOperation;

public class WaiterOperation : IWaiterOperation
{
    public AllCache Cache { get; set; }

    public Waiter CreateWaiter(string name, string password) =>
        Helper.WaiterByPassword(Cache, password, out Waiter waiterOnCache) is not null
            ? throw new EntityAlreadyExistsException(waiterOnCache.Id)
            : Cache.WaitersCache.AddWaiter(new Waiter(Guid.NewGuid(), name, password, WaiterSessionStatus.Closed));

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

    public Waiter GetWaiterById(Guid waiterId) =>
        Helper.WaiterById(Cache, waiterId, out Waiter waiterOnCache) is null
            ? throw new EntityNotFound(waiterId)
            : waiterOnCache;
}