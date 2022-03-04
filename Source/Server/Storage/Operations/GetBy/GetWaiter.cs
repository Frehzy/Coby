using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetWaiter
{

    public AllCache Cache { get; }

    public GetWaiter(AllCache cache) =>
        Cache = cache;

    public Waiter GetWaiterById(Guid waiterId) =>
        Helper.WaiterById(Cache, waiterId, out Waiter waiterOnCache) is null
            ? throw new EntityNotFound(waiterId)
            : waiterOnCache;

    public List<Waiter> GetWaiters() =>
        Cache.WaitersCache.GetWaitersCache();
}