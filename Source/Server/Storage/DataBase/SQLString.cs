using System;
using System.Collections.Generic;
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
        var hasBool = values.FirstOrDefault(x => x.GetType() == typeof(bool)) is not null;
        if (hasBool is false)
            return $"INSERT INTO {tableName}({string.Join(",", columnsName)}) VALUES ('{string.Join("','", values)}')";
        else
        {
            List<string> valuesWithBool = new();
            foreach (var val in values)
                if (val.GetType().Equals(typeof(bool)))
                    valuesWithBool.Add(val.ToString());
                else
                    valuesWithBool.Add($"'{val}'");

            return $"INSERT INTO {tableName}({string.Join(",", columnsName)}) VALUES ({string.Join(",", valuesWithBool)})";
        }
    }

    public static string GetDeleteSqlString(string tableName, Guid id) =>
        $"DELETE FROM {tableName} WHERE Id = '{id}'";
}