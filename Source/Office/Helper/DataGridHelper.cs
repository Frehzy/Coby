using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Office.Helper;

internal static class DataGridHelper
{
    public static void SetDGVColor(DataGridView dgv, Color color)
    {
        var dark_color = Color.FromArgb((int)(color.R * 0.7), (int)(color.G * 0.7), (int)(color.B * 0.7));
        var dark_dark_color = Color.FromArgb((int)(color.R * 0.85), (int)(color.G * 0.85), (int)(color.B * 0.85));

        dgv.BackgroundColor = color;

        dgv.RowsDefaultCellStyle.BackColor = color;
        dgv.RowsDefaultCellStyle.ForeColor = Color.Black;
        dgv.RowsDefaultCellStyle.SelectionBackColor = dark_dark_color;
        dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

        dgv.GridColor = dark_dark_color;

        dgv.ColumnHeadersDefaultCellStyle.BackColor = dark_color;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        dgv.RowHeadersDefaultCellStyle.BackColor = color;
        dgv.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
        dgv.RowHeadersDefaultCellStyle.SelectionBackColor = dark_dark_color;
    }

    public static void FillTable<T>(DataGridView dgv, T content)
    {
        DgvClear(dgv);
        if (content is null)
            return;

        var properties = content.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var property in properties)
            dgv.Columns.Add(property.Name, property.Name);

        var row = content.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Select(x => x.GetValue(content, null))
            .ToArray();

        dgv.Rows.Add(row);

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.AutoResizeColumns();
        dgv.RowHeadersVisible = false;
    }

    public static void FillTable<T>(DataGridView dgv, List<T> content)
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
                .Select(x => x.GetValue(item, null))
                .ToArray();

            dgv.Rows.Add(row);
        }

        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.AutoResizeColumns();
        dgv.RowHeadersVisible = false;
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

    public static void DgvClear(DataGridView dgv)
    {
        dgv.Columns.Clear();
        dgv.Rows.Clear();
        dgv.Refresh();
    }
}