using System;
using System.Windows.Forms;

namespace Office.Forms;

internal class RemoveRow
{
    private readonly DataGridView _dgv;

    public int Row { get; private set; }

    public int Column { get; private set; }

    public Guid Id { get; private set; }

    public RemoveRow(DataGridView dgv) =>
        _dgv = dgv;

    public RemoveRow GetIdBySelectedRow(string columnName = "Id")
    {
        var rowIndex = _dgv.CurrentCell?.RowIndex;
        if (rowIndex is null)
            throw new NullReferenceException("Должна быть выделена хотя-бы одна строка.");

        var columnIndex = DataGridHelper.GetIndexByName(_dgv, columnName);
        if (columnIndex is null)
            throw new NullReferenceException($"Не был найден столбец с именем {columnName}");

        Id = Guid.Parse(_dgv.Rows[(int)rowIndex].Cells[(int)columnIndex].Value.ToString());

        return MessageBox.Show(
            $"Вы действительно хотите удалить {rowIndex} строку?", default, MessageBoxButtons.YesNo) is DialogResult.Yes
            ? this
            : default;
    }
}