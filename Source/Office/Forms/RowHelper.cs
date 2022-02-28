using System;
using System.Windows.Forms;

namespace Office.Forms;

internal class RowHelper<T>
{
    private readonly DataGridView _dgv;

    public int? Row { get; private set; }

    public int? Column { get; private set; }

    public T Value { get; private set; }

    public RowHelper(DataGridView dgv) =>
        _dgv = dgv;

    public RowHelper<T> RemoveRow(string columnName = "Id")
    {
        Value = GetIdBySelectedRow(columnName);

        return MessageBox.Show(
            $"Вы действительно хотите удалить {Row} строку?", default, MessageBoxButtons.YesNo) is DialogResult.Yes
            ? this
            : default;
    }

    public T GetIdBySelectedRow(string columnName)
    {
        Row = _dgv.CurrentCell?.RowIndex;
        if (Row is null)
            throw new NullReferenceException("Должна быть выделена хотя-бы одна строка.");

        Column = DataGridHelper.GetIndexByName(_dgv, columnName);
        if (Column is null)
            throw new NullReferenceException($"Не был найден столбец с именем {columnName}");

        return (T)Convert.ChangeType(_dgv.Rows[(int)Row].Cells[(int)Column].Value, typeof(T));
    }
}