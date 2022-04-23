using Shared;
using Shared.Dto.Enities;
using Storage.Cache;
using System;

namespace Storage.Operations;

public class DangerousOperation
{
    public AllCache Cache { get; set; }

    public void AddDangerousOperations(Guid waiterId, string message)
    {
        var dangerousOperation = new DangerousOperationsDto(waiterId, message);
        Cache.DangerousOperationCache.AddDangerousOperations(dangerousOperation);
        Log.Info($"{nameof(DangerousOperationsDto)} added. {Log.GetFormatProperties(dangerousOperation)}");
    }

    public void GetDangerousOperations() =>
        Cache.DangerousOperationCache.GetDangerousOperationsCache();
}
