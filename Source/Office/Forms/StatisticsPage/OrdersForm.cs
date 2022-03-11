using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Entities;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Forms.StatisticsPage;

public partial class OrdersForm : MaterialForm
{
    private readonly IClient _client;
    private List<Order> _orders;

    public Func<List<Order>> GetOrders { get; private set; }

    public OrdersForm(IClient client, Func<List<Order>> getOrders)
    {
        InitializeComponent();
        _client = client;
        GetOrders = getOrders;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void OrdersUpdateButton_Click(object sender, EventArgs e)
    {
        _orders = GetOrders.Invoke();

        List<OfficeOrder> closeOrders = new();
        closeOrders.AddRange(_orders.Select(x => new OfficeOrder(x.Id,
                                                                x.Waiter.Name,
                                                                x.Table.TableNumber,
                                                                x.Sum.Value,
                                                                x.GetGuests().Count(),
                                                                x.StartTime,
                                                                x.EndTime)));
        DataGridHelper.FillTable(CloseOrdersDgv, closeOrders);
    }

    private void MoreInfoButton_Click(object sender, EventArgs e)
    {
        var orderId = new RowHelper<Guid>(CloseOrdersDgv).GetIdBySelectedRow("OrderId");
        var order = _orders.First(x => x.Id.Equals(orderId));
        var orderForm = new OrderForm(_client, order);
        orderForm.Show();
    }
}
