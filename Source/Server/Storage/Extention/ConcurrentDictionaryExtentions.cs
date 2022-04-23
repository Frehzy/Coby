using Storage.DataBase;
using System.Collections.Concurrent;

namespace Storage.Extention;

internal static class ConcurrentDictionaryExtentions
{
    public static TValue AddOrUpdateDB<Guid, TValue>(this ConcurrentDictionary<Guid, TValue> dictionary, Guid key, TValue value, DBInteraction db, string tableName)
    {
        if (dictionary.TryRemove(key, out _))
            db.ExecuteNonQuery(SQLString.GetDeleteSqlString(tableName, System.Guid.Parse(key.ToString())));

        db.ExecuteNonQuery(SQLString.GetInsertSqlString(value, tableName));
        dictionary.TryAdd(key, value);
        return value;
    }

    public static TValue? TryRemoveDB<Guid, TValue>(this ConcurrentDictionary<Guid, TValue> dictionary, Guid key, DBInteraction db, string tableName)
    {
        if (dictionary.TryRemove(key, out TValue removeValue))
            db.ExecuteNonQuery(SQLString.GetDeleteSqlString(tableName, System.Guid.Parse(key.ToString())));

        return removeValue is not null ? removeValue : default;
    }
}