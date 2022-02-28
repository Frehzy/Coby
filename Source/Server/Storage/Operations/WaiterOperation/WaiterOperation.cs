using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations.WaiterOperation;

public class WaiterOperation : IWaiterOperation
{
    public AllCache Cache { get; set; }

    public Waiter CreateWaiter(string name, string password)
    {
        if (Helper.WaiterByPassword(Cache, password, out Waiter waiterOnCache) is not null)
            throw new EntityAlreadyExistsException(waiterOnCache.Id);

        return Cache.WaitersCache.AddWaiter(new Waiter(Guid.NewGuid(), name, password, WaiterSessionStatus.Closed));
    }

    public Waiter OpenPersonalShift(Guid waiterId)
    {
        if (Helper.WaiterById(Cache, waiterId, out Waiter waiterOnCache) is null)
            throw new EntityNotFound(waiterId);

        waiterOnCache.Status = WaiterSessionStatus.Open;
        return waiterOnCache;
    }

    public Waiter ClosePersonalShift(Guid waiterId)
    {
        if (Helper.WaiterById(Cache, waiterId, out Waiter waiterOnCache) is null)
            throw new EntityNotFound(waiterId);

        waiterOnCache.Status = WaiterSessionStatus.Closed;
        return waiterOnCache;
    }
}