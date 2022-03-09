#nullable enable

using Shared.Dto.DGVEntities;
using System.Drawing;
using System.Windows.Forms;

namespace Coby.Forms.CustomControls;

public partial class CustomDataGridView : UserControl
{
    private OrderInfo? _selected;

    public OrderInfo? Selected => _selected;

    public CustomDataGridView() =>
        InitializeComponent();

    public void SetDGVColor(Color color)
    {
        var dark_color = Color.FromArgb((int)(color.R * 0.7), (int)(color.G * 0.7), (int)(color.B * 0.7));
        var dark_dark_color = Color.FromArgb((int)(color.R * 0.85), (int)(color.G * 0.85), (int)(color.B * 0.85));

        DGV.BackgroundColor = color;

        DGV.RowsDefaultCellStyle.BackColor = color;
        DGV.RowsDefaultCellStyle.ForeColor = Color.White;
        DGV.RowsDefaultCellStyle.SelectionBackColor = dark_dark_color;
        DGV.RowsDefaultCellStyle.SelectionForeColor = Color.White;

        DGV.GridColor = dark_dark_color;

        DGV.ColumnHeadersDefaultCellStyle.BackColor = dark_color;
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        DGV.RowHeadersDefaultCellStyle.BackColor = color;
        DGV.RowHeadersDefaultCellStyle.ForeColor = Color.White;
        DGV.RowHeadersDefaultCellStyle.SelectionBackColor = dark_dark_color;
    }

    public void SetDataBinding(string propertyName, object dataSource, string dataMember) =>
        DGV.DataBindings.Add(propertyName, dataSource, dataMember);

    private void DGV_Click(object sender, DataGridViewCellEventArgs e) =>
        UpdateSelectedRows();

    private void DGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) =>
        UpdateSelectedRows();

    private void UpdateSelectedRows() =>
        _selected = (OrderInfo)DGV.CurrentRow?.DataBoundItem;
}