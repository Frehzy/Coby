using Shared.Dto.Exceptions;
using Storage.Cache;
using Storage.DataBase;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetWaiterFace
{
    public AllCache Cache { get; }

    public GetWaiterFace(AllCache cache) =>
        Cache = cache;

    public List<WaiterFace> GetWaiterFaceById(Guid waiterId) =>
        Helper.WaiterFaceById(Cache, waiterId, out var waiterOnCache) is null
            ? throw new EntityNotFoundException(waiterId, typeof(WaiterFace))
            : waiterOnCache;

    public List<WaiterFace> GetWaiterFaces() =>
        Cache.WaiterFaceCache.GetWaiterFacesCache();
}