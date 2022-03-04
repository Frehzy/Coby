using Coby.ClientOperation;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class OrderForm : MaterialForm
{
    private int page = 0;

    public IClient Client { get; }

    public Waiter Waiter { get; private set; }

    public Order Order { get; }

    public OrderForm(IClient client, Guid orderId)
    {
        InitializeComponent();
        Client = client;
        Order = Client.GetByCacheOperation.GetOrder().GetOrderById(orderId);
        _ = FormHelper.CreateMaterialSkinManager(this);
        LoadOrderInfo();
        UpdateSumTextBox();
        LoadProductInfo(page);
    }

    private void LoadOrderInfo()
    {
        OrderInfoListView.Rows.Clear();
        foreach (var guest in Order.GetGuests())
        {
            OrderInfoListView.Rows.Add(guest.Name, default, default);
            foreach (var product in guest.GetProducts())
                OrderInfoListView.Rows.Add(default, product.ProductName, product.Price);
        }
        OrderInfoListView.AutoResizeColumns();
    }

    private void LoadProductInfo(int page)
    {
        ProductLayoutPanel.Controls.Clear();

        int cellCount = ProductLayoutPanel.ColumnCount * ProductLayoutPanel.RowCount;
        var products = Client.GetByCacheOperation.GetProduct().GetProducts().Skip(cellCount * page).Take(cellCount);

        List<MaterialButton> buttons = new();
        foreach (var product in products)
        {
            MaterialButton button = new();
            button.Click += (sender, e) => AddProductOnOrder(sender, e, product.Id);
            button.Text = $"{product.ProductName}\n{product.Price}";
            button.Dock = DockStyle.Fill;
            buttons.Add(button);
        }

        ProductLayoutPanel.Controls.AddRange(buttons.OrderBy(x => x.Text).ToArray());
    }

    private void AddProductOnOrder(object sender, EventArgs e, Guid productId)
    {
        Client.ProductOperation.AddProductOnOrder(Order.Id, default, productId);
    }

    private void UpdateSumTextBox() => SumTextBox.Text = $"Total price: {Order.Sum}";

    private void SaveButton_Click(object sender, EventArgs e)
    {
        Client.OrderOperation.SaveOrder(Order);
        Close();
    }

    private void CreateGuestButton_Click(object sender, EventArgs e)
    {
        Client.OrderOperation.GetGuestOperations(Order).AddGuestOnOrder();
        LoadOrderInfo();
    }

    private void UpButton_Click(object sender, EventArgs e)
    {
        page++;
        LoadProductInfo(page);
    }

    private void DownButton_Click(object sender, EventArgs e)
    {
        page--;
        LoadProductInfo(page);
    }

    private void OrderInfoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
