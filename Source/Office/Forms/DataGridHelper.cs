using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Office.Forms;

internal static class DataGridHelper
{
    public static void FillTable<T>(DataGridView dgv, IEnumerable<T> content)
    {
        DgvClear(dgv);

        if (content is null || content.Count() <= 0)
            return;

        var properties = content.First().GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var property in properties)
            dgv.Columns.Add(property.Name, property.Name);

        foreach (var item in content)
        {
            var row = item.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(x => x.GetValue(item, null)).ToArray();

            dgv.Rows.Add(row);
        }

        dgv.AutoResizeColumns();
    }

    public static int? GetIndexByName(DataGridView dgv, string name = "Id")
    {
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            if (column.Name.ToLower().Equals(name.ToLower()))
                return column.Index;
        }
        return default;
    }

    private static void DgvClear(DataGridView dgv)
    {
        dgv.Columns.Clear();
        dgv.Rows.Clear();
        dgv.Refresh();
    }
}