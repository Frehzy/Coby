using Coby.ClientOperation;
using Coby.Forms.MessageForms;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.DGVEntities;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class PayOrder : MaterialForm
{
    private readonly Credentials _credentials;

    private int _page;

    public BindingList<OrderInfo> OrderInfoBinding { get; set; }

    public IClient Client { get; }

    public Waiter Waiter { get; private set; }

    public Order Order { get; }

    public List<PaymentType> PaymentTypes { get; private set; }

    public int Page
    {
        get => _page;
        set
        {
            int cellCount = PaymentTypeLayoutPanel.ColumnCount * PaymentTypeLayoutPanel.RowCount;
            if (value >= 0 && value <= Math.Ceiling((decimal)(PaymentTypes.Count() / cellCount)))
                _page = value;
        }
    }

    public PayOrder(IClient client, Guid orderId, Credentials credentials)
    {
        InitializeComponent();
        Client = client;
        Order = Client.GetByCacheOperation.Order.GetOrderById(orderId);
        PaymentTypes = Client.GetByCacheOperation.PaymentType.GetPaymentTypes();
        _credentials = credentials;
        Waiter = Client.GetByCacheOperation.Waiter.GetWaiterById(credentials.WaiterId);
        _ = FormHelper.CreateMaterialSkinManager(this);
        FormHelper.SetFullScreen(this);
        OrderInfoListView.SetDataBinding("DataSource", this, nameof(OrderInfoBinding));
        OrderInfoListView.SetDGVColor(BackColor);
        OrderInfoBinding = new();
        LoadOrderInfo();
        LoadPaymentTypesInfo(Page);
        UpdateRemainderTextBox();
    }

    private void LoadOrderInfo()
    {
        OrderInfoBinding.Clear();
        foreach (var guest in Order.GetGuests())
        {
            OrderInfoBinding.Add(new OrderInfo(guest));
            foreach (var product in guest.Products)
                OrderInfoBinding.Add(new OrderInfo(guest, product.Key, product.Value));
        }
        UpdateSumTextBox();
    }

    private void LoadPaymentTypesInfo(int page)
    {
        PaymentTypeLayoutPanel.Controls.Clear();

        int cellCount = PaymentTypeLayoutPanel.ColumnCount * PaymentTypeLayoutPanel.RowCount;
        var paymentTypes = PaymentTypes.Skip(cellCount * page).Take(cellCount);

        List<MaterialButton> buttons = new();
        foreach (var paymentType in paymentTypes)
        {
            MaterialButton button = new();
            button.Click += (sender, e) => AddPaymentTypeOnOrder(sender, e, paymentType.Id);
            button.Text = $"{paymentType.Name}";
            button.Dock = DockStyle.Fill;
            buttons.Add(button);
        }

        PaymentTypeLayoutPanel.Controls.AddRange(buttons.OrderBy(x => x.Text).ToArray());

        void AddPaymentTypeOnOrder(object sender, EventArgs e, Guid paymentTypeId)
        {
            var paymentType = PaymentTypes.First(x => x.Id.Equals(paymentTypeId));
            try
            {
                var payment = new AddPaymentForm(paymentType.Name).AddPayment(_credentials, Client.OrderOperation.GetPaymentOperations(Order), paymentTypeId);
                if (payment is not null)
                {
                    PaymentTypes.RemoveAll(x => x.Id.Equals(paymentTypeId));
                    LoadPaymentTypesInfo(Page);
                    CreatePaymentInfo(payment);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message,
                                        false,
                                        FlexibleMaterialForm.ButtonsPosition.Center);
            } 
        }
    }

    private void UpdatePaymentLayoutPanel()
    {
        PaymentLayoutPanel.Controls.Clear();
        Order.GetPayments().ForEach(x => CreatePaymentInfo(x));
    }

    private void CreatePaymentInfo(Payment payment)
    {
        MaterialButton button = new();
        button.Click += (sender, e) => RemovePaymentOnOrder(sender, e, payment.Id);
        button.Text = $"{payment.Name}: {payment.Sum}";
        button.Dock = DockStyle.Fill;
        UpdateRemainderTextBox();
        PaymentLayoutPanel.Controls.Add(button);

        void RemovePaymentOnOrder(object sender, EventArgs e, Guid paymentId)
        {
            Client.OrderOperation.GetPaymentOperations(Order).RemovePaymentOnOrder(_credentials, paymentId);
            UpdatePaymentLayoutPanel();
            UpdateRemainderTextBox();
            var paymenttype = Client.GetByCacheOperation.PaymentType.GetPaymentTypeById(paymentId);
            PaymentTypes.Add(paymenttype);
            LoadPaymentTypesInfo(Page);
        }
    }

    private void UpdateRemainderTextBox()
    {
        var orderSum = Order.Sum - Order.GetPayments().Sum(x => x.Sum);
        RemainderTextBox.Text = orderSum >= 0
            ? $"Remainder: {orderSum}"
            : $"Change: {orderSum * (-1)}";
    }

    private void UpdateSumTextBox() => SumTextBox.Text = $"Total price: {Order.Sum}";

    private void BackButton_Click(object sender, EventArgs e) =>
        Close();

    private void DownButton_Click(object sender, EventArgs e)
    {
        Page++;
        LoadPaymentTypesInfo(Page);
    }

    private void UpButton_Click(object sender, EventArgs e)
    {
        Page--;
        LoadPaymentTypesInfo(Page);
    }

    private void PayButton_Click(object sender, EventArgs e)
    {
        if (Order.Sum - Order.GetPayments().Sum(x => x.Sum) > 0)
        {
            MaterialMessageBox.Show($"Невозможно закрыть заказ, пока внесённая сумма меньше 0.",
                                    false,
                                    FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }
        Client.OrderOperation.SaveOrder(Order);
        Client.OrderOperation.CloseOrder(_credentials, Order.Id);
        Close();
    }
}