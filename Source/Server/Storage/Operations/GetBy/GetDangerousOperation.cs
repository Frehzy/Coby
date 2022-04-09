using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetDangerousOperation
{
    public AllCache Cache { get; }

    public GetDangerousOperation(AllCache cache) =>
        Cache = cache;

    public DangerousOperationsDto GetDangerousOperationsByWaiterId(Guid waiterId) =>
        Helper.DangerousOperationsByWaiterId(Cache, waiterId, out var dangerousOperations) is not null
            ? dangerousOperations
            : throw new EntityNotFound(waiterId);

    public List<DangerousOperationsDto> GetDangerousOperations() =>
        Cache.DangerousOperationCache.GetDangerousOperationsCache();
}