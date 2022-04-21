using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Entities;
using Office.Forms.MessageForm;
using Office.Helper;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Forms;

public partial class ChartsForm : MaterialForm
{
    private readonly IClient _client;

    private Func<IEnumerable<Order>> _getOpenOrders => _client.GetByCacheOperation.Order.GetOrders;
    private Func<IEnumerable<Order>> _getCloseOrders => _client.GetCloseOrders.Invoke;

    private IEnumerable<Order> _orders => _getOpenOrders.Invoke().Concat(_getCloseOrders.Invoke());

    public ChartsForm(IClient client)
    {
        InitializeComponent();
        _client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void UpdateCloseOrdersButton_Click(object sender, EventArgs e)
    {
        var groupByForm = new GroupByForm(_orders.Where(x => x.Status is OrderStatus.Closed).ToList());
        var groupCloseOrders = groupByForm.GetGroupOrders().ToList();
        ClearCharts(CloseOrdersCharts);
        if (groupCloseOrders.Count == 0)
            return;

        CloseOrdersCharts.AxisX.Add(new Axis
        {
            Title = groupCloseOrders.First().TitleLabel,
            Labels = groupCloseOrders.Select(x => x.AxisXLabel.ToString()).ToArray()
        });
        CloseOrdersCharts.LegendLocation = LegendLocation.Right;

        if (groupByForm.DrawOrders is true)
            AddOrdersOnChart(CloseOrdersCharts, groupCloseOrders);

        if (groupByForm.DrawPayment is true)
            AddPaymentOnChart(CloseOrdersCharts, groupCloseOrders);
    }

    private void ClearCharts(LiveCharts.WinForms.CartesianChart chart)
    {
        chart.AxisX.Clear();
        chart.AxisY.Clear();
        chart.Series.Clear();
    }

    private void AddOrdersOnChart(LiveCharts.WinForms.CartesianChart cartesianChart, IEnumerable<GroupOrders> orders)
    {
        cartesianChart.Series.Add(new LineSeries()
        {
            Title = "Orders count",
            Values = new ChartValues<int>(orders.Select(x => x.Orders.Count()))
        });
    }

    private void AddPaymentOnChart(LiveCharts.WinForms.CartesianChart cartesianChart, IEnumerable<GroupOrders> orders)
    {
        cartesianChart.Series.Add(new LineSeries()
        {
            Title = "Order sum",
            Values = new ChartValues<decimal>(orders.Select(x => x.Orders.Sum(x => (decimal)x.Sum)))
        });

        cartesianChart.Series.Add(new LineSeries()
        {
            Title = "Order cash sum",
            Values = new ChartValues<decimal>(orders.Select(x => x.Orders.SelectMany(x => x.GetPayments())
                                                                         .Where(x => x.PaymentEnum is PaymentEnum.Cash)
                                                                         .Sum(x => x.Sum)))
        });

        cartesianChart.Series.Add(new LineSeries()
        {
            Title = "Order non-cash sum",
            Values = new ChartValues<decimal>(orders.Select(x => x.Orders.SelectMany(x => x.GetPayments())
                                                                         .Where(x => x.PaymentEnum is PaymentEnum.NonCash)
                                                                         .Sum(x => x.Sum)))
        });

        cartesianChart.Series.Add(new LineSeries()
        {
            Title = "Order other sum",
            Values = new ChartValues<decimal>(orders.Select(x => x.Orders.SelectMany(x => x.GetPayments())
                                                                         .Where(x => x.PaymentEnum is PaymentEnum.Other)
                                                                         .Sum(x => x.Sum)))
        });
    }
}