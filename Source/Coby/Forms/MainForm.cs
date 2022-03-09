using Coby.ClientOperation;
using Coby.Forms.CustomControls.CardView;
using Coby.Forms.CustomControls.CardView.Anim;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class MainForm : MaterialForm
{
    private int _page;

    public IClient Client { get; }

    public Waiter Waiter { get; private set; }

    public Credentials Credentials { get; }

    public List<Order> Orders { get; private set; }

    public int Page
    {
        get => _page;
        set
        {
            int cellCount = OpenOrderLayoutPanel.ColumnCount * OpenOrderLayoutPanel.RowCount;
            if (value >= 0 && value <= Math.Ceiling((decimal)(Orders.Count() / cellCount)))
                _page = value;
        }
    }

    public MainForm(IClient client, Credentials credentials)
    {
        InitializeComponent();
        Client = client;
        Credentials = credentials;
        Waiter = Client.GetByCacheOperation.GetWaiter().GetWaiterById(Credentials.WaiterId);
        Orders = Client.GetByCacheOperation.GetOrder().GetOrders().Where(x => x.OrderStatus is OrderStatus.New).ToList();
        _ = FormHelper.CreateMaterialSkinManager(this);
        AfterUpdateStatus();
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

    private void CafeSessionClose_Click(object sender, EventArgs e)
    {
        var request = Task.Run(() => Client.CloseCafeShift(Credentials)).Result;
        if (request.Status is not RequestStatus.OK)
            MaterialMessageBox.Show($"Id: {request.Id}\nStatus: {request.Status}\nMessage: {request.Message}\nException:{request.Exception}");
        AfterUpdateStatus();
    }

    private void CreateOrderButton_Click(object sender, EventArgs e) =>
        OpenForm(new CreateOrderForm(Client, Credentials));

    private void MainFormTabController_Selecting(object sender, TabControlCancelEventArgs e)
    {
        TabPage currentPage = (sender as TabControl).SelectedTab;
        if (currentPage.Name.Equals(nameof(OrdersPage)))
        {
            Page = 0;
            UpdateOrdersLayoutPanel(Page);
        }
    }

    private void AfterUpdateStatus()
    {
        if (Waiter.Status is WaiterSessionStatus.Open)
        {
            Page = 0;
            UpdateOrdersLayoutPanel(Page);
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

        int cellCount = OpenOrderLayoutPanel.ColumnCount * OpenOrderLayoutPanel.RowCount;
        Orders = Client.GetByCacheOperation.GetOrder().GetOrders().Where(x => x.OrderStatus is OrderStatus.New).ToList();
        var orders = Orders.Skip(cellCount * page).Take(cellCount);

        List<CustomCardView> cardViews = new();
        foreach (var order in orders)
        {
            CustomCardView view = new();
            view.SetColorAndFont(BackColor, Font);
            view.TextHeader = $"Table {order.Table.TableNumber}";
            view.Text = "More information";
            string products = string.Join(string.Format("{0}-", Environment.NewLine), order.GetGuests().SelectMany(x => x.GetProducts()).Take(6).Select(x => x.ProductName));
            view.TextDescrition = $"GuestCount: {order.GetGuests().Count()}\n" +
                                  $"Sum: {order.Sum}\n" +
                                  $"StartTime: {order.StartTime}\n" +
                                  $"Products: \n-{products}";
            view.MouseClick += (sender, e) => OpenOrder(sender, e, order.Id, view.CurtainHeight);
            view.Dock = DockStyle.Fill;

            cardViews.Add(view);
        }

        OpenOrderLayoutPanel.Controls.AddRange(cardViews.OrderBy(x => x.Name).ToArray());

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

        newForm.FormClosing += (sender, e) =>
        {
            Enabled = true;
            Page = 0;
            UpdateOrdersLayoutPanel(Page);
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
        OpenForm(new CloseOrdersForm(Client, Client.GetByCacheOperation.GetOrder().GetOrders().Where(x => x.OrderStatus is OrderStatus.Closed)));
}
