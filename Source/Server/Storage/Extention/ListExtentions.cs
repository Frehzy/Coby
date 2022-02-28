#nullable enable

using Storage.DataBase;
using System.Collections.Generic;

namespace Storage.Extention;

internal static class ListExtentions
{
    public static TValue AddDB<TValue>(this List<TValue> list, TValue value, DBInteraction db, string tableName)
    {
        db.ExecuteNonQuery(SQLString.GetInsertSqlString(value, tableName));
        list.Add(value);
        return value;
    }
}