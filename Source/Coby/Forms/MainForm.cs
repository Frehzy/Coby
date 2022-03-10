using Coby.ClientOperation;
using Coby.Forms.CustomControls.CardView;
using Coby.Forms.CustomControls.CardView.Anim;
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
    private int _page;
    private List<Order> _orders;
    private readonly int _openOrderLayoutPanelCellCount;

    public IClient Client { get; }

    public Waiter Waiter { get; private set; }

    public Credentials Credentials { get; }

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
        Client = client;
        Credentials = credentials;
        Waiter = Client.GetByCacheOperation.GetWaiter().GetWaiterById(Credentials.WaiterId);
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
            ? Client.WaiterOperation.ClosePersonalShift(Waiter.Id)
            : Client.WaiterOperation.OpenPersonalShift(Waiter.Id);
        AfterUpdateStatus();
        MaterialMessageBox.Show($"Личная смена имеет статус: {Waiter.Status}", false, FlexibleMaterialForm.ButtonsPosition.Center);
    }

    private void LockButton_Click(object sender, EventArgs e)
    {
        new LoginForm(Client).Show();
        Hide();
    }

    private async void CafeSessionClose_Click(object sender, EventArgs e)
    {
        var splashScreen = new SplashScreen();
        splashScreen.Show();
        Enabled = false;
        splashScreen.FormClosing += (sender, e) => { Enabled = true; };

        var request = await Client.CloseCafeShift(Credentials);
        if (request.Status is not RequestStatus.OK)
            MaterialMessageBox.Show($"Id: {request.Id}\nStatus: {request.Status}\nMessage: {request.Message}\nException:{request.Exception}");
        Waiter = Client.GetByCacheOperation.GetWaiter().GetWaiterById(Waiter.Id);
        AfterUpdateStatus();

        splashScreen.Close();
    }

    private void CreateOrderButton_Click(object sender, EventArgs e) =>
        OpenForm(new CreateOrderForm(Client, Credentials));

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
                OpenForm(new OrderForm(Client, orderId));
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

    private void CloseOrdersButton_Click(object sender, EventArgs e) =>
        OpenForm(new CloseOrdersForm(Client, Client.GetByCacheOperation.GetOrder().GetOrders().Where(x => x.Status is OrderStatus.Closed)));

    private void UpdateOrders() =>
        Orders = Client.GetByCacheOperation.GetOrder().GetOrders().Where(x => x.Status is OrderStatus.New).ToList();

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(PropertyChangedEventArgs e) =>
        PropertyChanged?.Invoke(this, e);

    protected void OnPropertyChanged(string propertyName) =>
        OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
}