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

    public PayOrder(IClient client, Guid orderId)
    {
        InitializeComponent();
        Client = client;
        Order = Client.GetByCacheOperation.GetOrder().GetOrderById(orderId);
        PaymentTypes = Client.GetByCacheOperation.GetPaymentType().GetPaymentTypes();
        _ = FormHelper.CreateMaterialSkinManager(this);
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
            var payment = new AddPaymentForm(paymentType.Name).AddPayment(Client.OrderOperation.GetPaymentOperations(Order), paymentTypeId);
            if (payment is not null)
            {
                PaymentTypes.RemoveAll(x => x.Id.Equals(paymentTypeId));
                LoadPaymentTypesInfo(Page);
                CreatePaymentInfo(payment);
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
            Client.OrderOperation.GetPaymentOperations(Order).RemovePaymentOnOrder(paymentId);
            UpdatePaymentLayoutPanel();
            UpdateRemainderTextBox();
            var paymenttype = Client.GetByCacheOperation.GetPaymentType().TryGetPaymentTypeById(paymentId);
            PaymentTypes.Add(paymenttype);
            LoadPaymentTypesInfo(Page);
        }
    }

    private void UpdateRemainderTextBox() => RemainderTextBox.Text = $"Remainder: {Order.Sum - Order.GetPayments().Sum(x => x.Sum)}";

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
        if (Order.Sum - Order.GetPayments().Sum(x => x.Sum) != 0)
        {
            MaterialMessageBox.Show($"Невозможно закрыть заказ, пока сумма на остатке не будет равна 0.",
                                    false,
                                    FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }
        Client.OrderOperation.SaveOrder(Order);
        Client.OrderOperation.CloseOrder(Order.Id);
        Close();
    }
}