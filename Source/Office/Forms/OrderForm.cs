using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Helper;
using Shared.Dto.DGVEntities;
using Shared.Dto.Enities;
using System;
using System.ComponentModel;

namespace Office.Forms;

public partial class OrderForm : MaterialForm
{
    public BindingList<OrderInfo> OrderInfoBinding { get; set; } = new();

    public IClient Client { get; }

    public Order Order { get; }

    public OrderForm(IClient client, Order order)
    {
        InitializeComponent();
        Client = client;
        Order = order;
        _ = FormHelper.CreateMaterialSkinManager(this);
        LoadOrderInfo();
        LoadWaiterInfo();
        LoadTableInfo();
        LoadPaymentsInfo();
    }

    private void LoadPaymentsInfo()
    {
        DataGridHelper.FillTable(PaymentInfoDgv, Order.GetPayments());
        DataGridHelper.SetDGVColor(PaymentInfoDgv, BackColor);
    }

    private void LoadTableInfo()
    {
        DataGridHelper.FillTable(TableInfoDgv, Order.Table);
        DataGridHelper.SetDGVColor(TableInfoDgv, BackColor);
    }

    private void LoadWaiterInfo()
    {
        DataGridHelper.FillTable(WaiterInfoDgv, Order.Waiter);
        DataGridHelper.SetDGVColor(WaiterInfoDgv, BackColor);
    }

    private void LoadOrderInfo()
    {
        OrderInfoDgv.DataBindings.Add("DataSource", this, nameof(OrderInfoBinding));
        DataGridHelper.SetDGVColor(OrderInfoDgv, BackColor);
        OrderInfoBinding = new();
        foreach (var guest in Order.GetGuests())
        {
            OrderInfoBinding.Add(new OrderInfo(guest));
            foreach (var product in guest.Products)
                OrderInfoBinding.Add(new OrderInfo(guest, product.Key, product.Value));
        }
        UpdateSumTextBox();
    }

    private void UpdateSumTextBox() => SumTextBox.Text = $"Total price: {Order.Sum}";
}
