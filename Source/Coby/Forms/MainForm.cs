using Coby.ClientOperation;
using Coby.Forms.CustomControls.CardView;
using Coby.Forms.CustomControls.CardView.Anim;
using Coby.Forms.MessageForms;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class MainForm : MaterialForm, INotifyPropertyChanged
{
    private readonly int _openOrderLayoutPanelCellCount;
    private readonly IClient _client;
    private readonly Credentials _credentials;

    private int _page;
    private List<Order> _orders;

    public Waiter Waiter { get; private set; }

    public List<Order> Orders
    {
        get => _orders;
        set
        {
            _orders = value;
            OnPropertyChanged(nameof(Orders));
            UpdateOrdersLayoutPanel(Page);
        }
    }

    public int Page
    {
        get => _page;
        set
        {
            if (value >= 0 && value <= Math.Ceiling((decimal)(Orders.Count() / _openOrderLayoutPanelCellCount)))
                _page = value;
        }
    }

    public MainForm(IClient client, Credentials credentials)
    {
        InitializeComponent();
        _client = client;
        _credentials = credentials;
        Waiter = _client.GetByCacheOperation.Waiter.GetWaiterById(_credentials.WaiterId);
        WaiterLabel.Text = $"{Waiter.PermissionStatus}: {Waiter.Name}";
        _openOrderLayoutPanelCellCount = OpenOrderLayoutPanel.ColumnCount * OpenOrderLayoutPanel.RowCount;
        _ = FormHelper.CreateMaterialSkinManager(this);
        FormHelper.SetFullScreen(this);
        AfterUpdateStatus();
        UpdateOrders();
        Animator.Start();
    }

    private void ChangePersonalShiftStatus_Click(object sender, EventArgs e)
    {
        Waiter = Waiter.Status is WaiterSessionStatus.Open
            ? _client.WaiterOperation.ClosePersonalShift(Waiter.Id)
            : _client.WaiterOperation.OpenPersonalShift(Waiter.Id);
        AfterUpdateStatus();
        MaterialMessageBox.Show($"Личная смена имеет статус: {Waiter.Status}", false, FlexibleMaterialForm.ButtonsPosition.Center);
    }

    private void LockButton_Click(object sender, EventArgs e)
    {
        new LoginForm(_client).Show();
        Hide();
    }

    private async void CafeSessionClose_Click(object sender, EventArgs e)
    {
        var cashRegister = new CashRegister(new EnterRemainderCashForm().GetRemainderCash());
        if (cashRegister.CashOnRegister is decimal.Zero)
            return;

        var splashScreen = new SplashScreen();
        splashScreen.Show();
        Enabled = false;
        splashScreen.FormClosing += (sender, e) => { Enabled = true; };

        var request = await _client.CloseCafeShift(_credentials, cashRegister);
        splashScreen.Close();

        if (request.Status is not RequestStatus.OK)
            MaterialMessageBox.Show($"Id: {request.Id}\nStatus: {request.Status}\nMessage: {request.Message}\nException:{request.Exception}");
        Waiter = _client.GetByCacheOperation.Waiter.GetWaiterById(Waiter.Id);
        AfterUpdateStatus();
    }

    private void CreateOrderButton_Click(object sender, EventArgs e) =>
        OpenForm(new CreateOrderForm(_client, _credentials));

    private void MainFormTabController_Selecting(object sender, TabControlCancelEventArgs e)
    {
        TabPage currentPage = (sender as TabControl).SelectedTab;
        if (currentPage.Name.Equals(nameof(OrdersPage)))
        {
            Page = 0;
            UpdateOrders();
        }
    }

    private void AfterUpdateStatus()
    {
        if (Waiter.Status is WaiterSessionStatus.Open)
        {
            MainFormTabController.SelectTab(OrdersPage);
            ChangeControlEnable(OrdersPage.Controls, true);
            PersonalShiftController.Text = "Закрыть личную смену";
        }
        else
        {
            MainFormTabController.SelectTab(OptionsPage);
            ChangeControlEnable(OrdersPage.Controls, false);
            PersonalShiftController.Text = "Открыть личную смену";
        }

        static void ChangeControlEnable(Control.ControlCollection controls, bool status)
        {
            foreach (Control control in controls)
                control.Enabled = status;
        }
    }

    private void UpdateOrdersLayoutPanel(int page)
    {
        OpenOrderLayoutPanel.Controls.Clear();
        var orders = Orders.Skip(_openOrderLayoutPanelCellCount * page).Take(_openOrderLayoutPanelCellCount);

        List<CustomCardView> cardViews = new();
        foreach (var order in orders)
        {
            CustomCardView view = new();
            view.SetColorAndFont(BackColor, Font);
            view.TextHeader = $"Table {order.Table.TableNumber}";
            view.Text = "More information";
            string products = string.Join($"{Environment.NewLine}-", order.GetGuests().SelectMany(x => x.GetProducts()).Take(6).Select(x => x.ProductName));
            view.TextDescrition = $"GuestCount: {order.GetGuests().Count()}\n" +
                                  $"Sum: {order.Sum}\n" +
                                  $"Waiter: {order.Waiter.Name}\n" +
                                  $"StartTime: {order.StartTime}\n" +
                                  $"Products: \n-{products}";
            view.Tag = order.StartTime;
            view.MouseClick += (sender, e) => OpenOrder(sender, e, order.Id, view.CurtainHeight);
            view.Dock = DockStyle.Fill;

            cardViews.Add(view);
        }

        OpenOrderLayoutPanel.Controls.AddRange(cardViews.OrderBy(x => x.Tag).ToArray());

        void OpenOrder(object sender, MouseEventArgs e, Guid orderId, int y)
        {
            if (e.Y <= y)
                OpenForm(new OrderForm(_client, Waiter, orderId));
        }
    }

    private void OpenForm(MaterialForm newForm)
    {
        Enabled = false;
        newForm.Show();

        newForm.FormClosed += (sender, e) =>
        {
            Enabled = true;
            Page = 0;
            UpdateOrders();
        };
    }

    private void UpButton_Click(object sender, EventArgs e)
    {
        Page--;
        UpdateOrdersLayoutPanel(Page);
    }

    private void DownButton_Click(object sender, EventArgs e)
    {
        Page++;
        UpdateOrdersLayoutPanel(Page);
    }

    private void StatisticsButton_Click(object sender, EventArgs e)
    {
        var orders = _client.GetByCacheOperation.Order.GetOrders();
        var openOrders = orders.Where(x => x.Status is OrderStatus.New);
        var closedOrders = orders.Where(x => x.Status is OrderStatus.Closed);

        var cash = orders.SelectMany(x => x.GetPayments()).Where(x => x.PaymentEnum is PaymentEnum.Cash).Sum(x => x.Sum);
        var realCash = orders.Sum(x => x.Sum) - orders.SelectMany(x => x.GetPayments())
                                                      .Where(x => x.PaymentEnum is not PaymentEnum.Cash)
                                                      .Sum(x => x.Sum);
        var nonCash = orders.SelectMany(x => x.GetPayments()).Where(x => x.PaymentEnum is PaymentEnum.NonCash).Sum(x => x.Sum);
        var other = orders.SelectMany(x => x.GetPayments()).Where(x => x.PaymentEnum is PaymentEnum.Other).Sum(x => x.Sum);

        var reserveLicence = _client.GetByCacheOperation.Cache.LicensesCache.GetLicensesCache();

        string message = $"Open orders: {openOrders.Count()}\n" +
                         $"Closed orders: {closedOrders.Count()}\n" +
                         $"Cash: {cash}\n" +
                         $"Real cash: {realCash}\n" +
                         $"Non cash: {nonCash}\n" +
                         $"Other: {other}\n" +
                         $"Reserve license: {reserveLicence.Count()}";
        MaterialMessageBox.Show(message, false, FlexibleMaterialForm.ButtonsPosition.Center);
    }

    private void CloseOrdersButton_Click(object sender, EventArgs e) =>
        OpenForm(new CloseOrdersForm(_client, _client.GetByCacheOperation.Order.GetOrders().Where(x => x.Status is OrderStatus.Closed)));

    private void UpdateOrders() =>
        Orders = _client.GetByCacheOperation.Order.GetOrders().Where(x => x.Status is OrderStatus.New).ToList();

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(PropertyChangedEventArgs e) =>
        PropertyChanged?.Invoke(this, e);

    protected void OnPropertyChanged(string propertyName) =>
        OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
}