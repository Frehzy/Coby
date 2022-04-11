using Storage.Cache;
using System;

namespace Storage.Operations;

public class DangerousOperation
{
    public AllCache Cache { get; set; }

    public void AddDangerousOperations(Guid waiterId, string message) =>
        Cache.DangerousOperationCache.AddDangerousOperations(new(waiterId, message));

    public void GetDangerousOperations() =>
        Cache.DangerousOperationCache.GetDangerousOperationsCache();
}
