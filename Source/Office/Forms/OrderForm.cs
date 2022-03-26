using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Helper;
using Shared.Dto.DGVEntities;
using Shared.Dto.Enities;
using System.ComponentModel;

namespace Office.Forms;

public partial class OrderForm : MaterialForm
{
    public BindingList<OrderInfo> OrderInfoBinding { get; set; } = new();

    public BindingList<History> HistoryBinding { get; set; } = new();

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
        LoadHistory();
    }

    private void LoadHistory()
    {
        HistoryDgv.DataBindings.Add("DataSource", this, nameof(HistoryBinding));
        DataGridHelper.SetDGVColor(HistoryDgv, BackColor);
        HistoryBinding = new();
        foreach (var history in Order.GetHistories())
            HistoryBinding.Add(history);
        DataGridHelper.SetDGVColor(AfterClickInfoDgv, BackColor);
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

    private void HistoryDgv_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
    {
        var selected = (History)HistoryDgv.CurrentRow?.DataBoundItem;
        if (selected is not null)
            LoadInfo();

        void LoadInfo()
        {
            var product = Client.GetByCacheOperation.Product.TryGetProductById(selected.TargetId);
            var paymentType = Client.GetByCacheOperation.PaymentType.TryGetPaymentTypeById(selected.TargetId);
            if (product is not null)
                DataGridHelper.FillTable(AfterClickInfoDgv, product);
            else if (paymentType is not null)
                DataGridHelper.FillTable(AfterClickInfoDgv, paymentType);
            else
                DataGridHelper.DgvClear(AfterClickInfoDgv);
        }
    }
}
