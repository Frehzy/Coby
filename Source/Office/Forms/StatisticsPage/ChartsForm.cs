using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Forms.MessageForm;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Forms;

public partial class ChartsForm : MaterialForm
{
    private Func<List<Order>> _getOpenOrders => _client.GetByCacheOperation.GetOrder().GetOrders;
    private Func<List<Order>> _getCloseOrders => _client.GetCloseOrders.Invoke;
    private List<Order> _orders => _getOpenOrders.Invoke().Concat(_getCloseOrders.Invoke()).ToList();
    private readonly IClient _client;

    public ChartsForm(IClient client)
    {
        InitializeComponent();
        _client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void UpdateCloseOrdersButton_Click(object sender, EventArgs e)
    {
        var result = new GroupByForm(_orders).GetGroupOrders().ToList();
        ClearCharts(CloseOrdersCharts);
        if (result.Count == 0)
            return;

        CloseOrdersCharts.AxisX.Add(new Axis
        {
            Title = result.First().TitleLabel,
            Labels = result.Select(x => x.AxisXLabel.ToString()).ToArray()
        });
        CloseOrdersCharts.LegendLocation = LegendLocation.Right;
        CloseOrdersCharts.Series.Add(new LineSeries()
        {
            Title = "Count",
            Values = new ChartValues<int>(result.Select(x => x.Orders.Count()))
        });
    }

    private void ClearCharts(LiveCharts.WinForms.CartesianChart chart)
    {
        chart.AxisX.Clear();
        chart.AxisY.Clear();
        chart.Series.Clear();
    }
}