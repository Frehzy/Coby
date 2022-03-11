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
    public IClient Client { get; }

    public Func<List<Order>> GetOrders { get; private set; }

    public List<Order> Orders { get; private set; }

    public OrdersForm(IClient client, Func<List<Order>> getOrders)
    {
        InitializeComponent();
        Client = client;
        GetOrders = getOrders;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void OrdersUpdateButton_Click(object sender, EventArgs e)
    {
        Orders = GetOrders.Invoke();

        List<OfficeOrder> closeOrders = new();
        closeOrders.AddRange(Orders.Select(x => new OfficeOrder(x.Id,
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
        var order = Orders.First(x => x.Id.Equals(orderId));
        var orderForm = new OrderForm(Client, order);
        orderForm.Show();
    }
}
