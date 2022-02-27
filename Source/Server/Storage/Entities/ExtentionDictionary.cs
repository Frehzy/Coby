#nullable enable

using System.Collections.Generic;

namespace Storage.Entities;

internal static class ExtentionDictionary
{
    public static TValue? TryAdd<Guid, TValue>(this Dictionary<Guid, TValue> dictionary, Guid key, TValue value)
    {
        if (dictionary.ContainsKey(key))
            return default;

        dictionary.Add(key, value);
        return value;
    }

    public static bool TryRemove<Guid, TValue>(this Dictionary<Guid, TValue> dictionary, Guid key)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary.Remove(key);
            return true;
        }

        return false;
    }

    public static TValue AddOrUpdate<Guid, TValue>(this Dictionary<Guid, TValue> dictionary, Guid key, TValue value)
    {
        if (dictionary.ContainsKey(key))
            dictionary.Remove(key);

        dictionary.Add(key, value);
        return value;
    }
}