using Coby.ClientOperation;
using Coby.Entities;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class OrderForm : MaterialForm, INotifyPropertyChanged
{
    private int _page;
    private BindingList<OrderInfo> _orderInfoBinding = new();

    public int Page
    {
        get => _page;
        set
        {
            int cellCount = ProductLayoutPanel.ColumnCount * ProductLayoutPanel.RowCount;
            if (value >= 0 && value <= Math.Ceiling((decimal)(Products.Count() / cellCount)))
                _page = value;
        }
    }

    public BindingList<OrderInfo> OrderInfoBinding
    {
        get => _orderInfoBinding;
        set
        {
            _orderInfoBinding = value;
            OnPropertyChanged();
        }
    }

    public IClient Client { get; }

    public Waiter Waiter { get; private set; }

    public Order Order { get; }

    public List<Product> Products { get; private set; }

    public OrderForm(IClient client, Guid orderId)
    {
        InitializeComponent();
        Client = client;
        Order = Client.GetByCacheOperation.GetOrder().GetOrderById(orderId);
        Products = Client.GetByCacheOperation.GetProduct().GetProducts();
        Page = 0;
        _ = FormHelper.CreateMaterialSkinManager(this);
        OrderInfoListView.SetDataBinding("DataSource", this, nameof(OrderInfoBinding));
        OrderInfoListView.SetDGVColor(BackColor);
        OrderInfoBinding = new();
        LoadOrderInfo();
        LoadProductInfo(_page);
    }

    private void LoadOrderInfo()
    {
        OrderInfoBinding.Clear();
        foreach (var guest in Order.GetGuests())
        {
            OrderInfoBinding.Add(new OrderInfo(guest));
            foreach (var product in guest.GetProducts())
                OrderInfoBinding.Add(new OrderInfo(guest, product.Key, product.Value));
        }
        UpdateSumTextBox();
    }

    private void LoadProductInfo(int page)
    {
        ProductLayoutPanel.Controls.Clear();

        int cellCount = ProductLayoutPanel.ColumnCount * ProductLayoutPanel.RowCount;
        var products = Products.Skip(cellCount * page).Take(cellCount);

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
        if (OrderInfoListView.Selected is null)
        {
            MaterialMessageBox.Show("Не выбран гость.", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }
        Client.OrderOperation.GetProductOperation(Order).AddProductOnOrder(OrderInfoListView.Selected.GuestId, productId);
        LoadOrderInfo();
    }

    private void UpdateSumTextBox() => SumTextBox.Text = $"Total price: {Order.Sum}";

    private void CreateGuestButton_Click(object sender, EventArgs e)
    {
        Client.OrderOperation.GetGuestOperations(Order).AddGuestOnOrder();
        LoadOrderInfo();
    }

    private void UpButton_Click(object sender, EventArgs e)
    {
        Page--;
        LoadProductInfo(Page);
    }

    private void DownButton_Click(object sender, EventArgs e)
    {
        Page++;
        LoadProductInfo(Page);
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        Client.OrderOperation.SaveOrder(Order);
        Close();
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        var selected = OrderInfoListView.Selected;
        if (selected is null)
        {
            MaterialMessageBox.Show("Не выбран элемент для удаления.", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }
        if (selected.ProductId.Equals(Guid.Empty))
        {
            if (Order.GetGuests().First(x => x.Id.Equals(selected.GuestId)).GetProducts().Count() > 0)
            {
                MaterialMessageBox.Show("Невозможно удалить гостя, у которого есть продукты.", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }
            Client.OrderOperation.GetGuestOperations(Order).RemoveGuestOnOrderById(selected.GuestId);
        }
        else
            Client.OrderOperation.GetProductOperation(Order).RemoveProductOnOrder(selected.GuestId, selected.ProductId, selected.Rank);
        LoadOrderInfo();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}