using System;
using System.Linq;
using System.Reflection;

namespace Storage.DataBase;

internal static class SQLString
{
    public static string GetInsertSqlString<TValue>(TValue value, string tableName)
    {
        var columnsName = value.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(x => x.Name).ToArray();
        var values = value.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Select(x => x.GetValue(value, null));

        return $"INSERT INTO {tableName}({string.Join(",", columnsName)}) VALUES ('{string.Join("','", values)}')";
    }

    public static string GetDeleteSqlString(string tableName, Guid id) =>
        $"DELETE FROM {tableName} WHERE Id = '{id}'";
}