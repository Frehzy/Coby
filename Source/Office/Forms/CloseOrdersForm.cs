using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Entities;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Forms;

public partial class CloseOrdersForm : MaterialForm
{
    public IClient Client { get; }

    public List<Order> CloseOrders { get; private set; }

    public CloseOrdersForm(IClient client)
    {
        InitializeComponent();
        Client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void OrdersUpdateButton_Click(object sender, EventArgs e)
    {
        CloseOrders = Client.GetCloseOrders();

        List<CloseOrder> closeOrders = new();
        closeOrders.AddRange(CloseOrders.Select(x => new CloseOrder(x.Id,
                                                                    x.Waiter.Name,
                                                                    x.Table.TableNumber,
                                                                    x.Sum.Value,
                                                                    x.GetGuests().Count(),
                                                                    x.StartTime,
                                                                    (DateTime)x.EndTime)));
        DataGridHelper.FillTable(CloseOrdersDgv, closeOrders);
    }

    private void MoreInfoButton_Click(object sender, EventArgs e)
    {
        var orderId = new RowHelper<Guid>(CloseOrdersDgv).GetIdBySelectedRow("OrderId");
        var order = CloseOrders.First(x => x.Id.Equals(orderId));
        var orderForm = new OrderForm(Client, order);
        orderForm.Show();
    }
}
