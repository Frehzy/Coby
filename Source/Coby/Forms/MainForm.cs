using Coby.ClientOperation;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class MainForm : MaterialForm
{
    public IClient Client { get; }

    public Waiter Waiter { get; private set; }

    public Credentials Credentials { get; }

    public MainForm(IClient client, Credentials credentials)
    {
        InitializeComponent();
        Client = client;
        Credentials = credentials;
        Waiter = Client.GetByCacheOperation.GetWaiter().GetWaiterById(Credentials.WaiterId);
        AfterUpdateStatus();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void ChangePersonalShiftStatus_Click(object sender, EventArgs e)
    {
        Waiter = Waiter.Status is WaiterSessionStatus.Open
            ? Client.WaiterOperation.ClosePersonalShift(Waiter.Id)
            : Client.WaiterOperation.OpenPersonalShift(Waiter.Id);
        AfterUpdateStatus();
        MaterialMessageBox.Show($"Личная смена имеет статус: {Waiter.Status}", false, FlexibleMaterialForm.ButtonsPosition.Center);
    }

    private void AfterUpdateStatus()
    {
        if (Waiter.Status is WaiterSessionStatus.Open)
        {
            MainFormTabController.SelectTab(OrdersPage);
            ChangeControlEnable(CreateOrderPage.Controls, true);
            ChangeControlEnable(OrdersPage.Controls, true);
            PersonalShiftController.Text = "Закрыть личную смену";
        }
        else
        {
            MainFormTabController.SelectTab(OptionsPage);
            ChangeControlEnable(CreateOrderPage.Controls, false);
            ChangeControlEnable(OrdersPage.Controls, false);
            PersonalShiftController.Text = "Открыть личную смену";
        }

        static void ChangeControlEnable(Control.ControlCollection controls, bool status)
        {
            foreach (Control control in controls)
                control.Enabled = status;
        }
    }

    private void LockButton_Click(object sender, EventArgs e)
    {
        new LoginForm(Client).Show();
        Hide();
    }

    private void CafeSessionClose_Click(object sender, EventArgs e)
    {
        if (Client.OrderOperation.GetOrders().Where(x => x.OrderStatus is OrderStatus.New).Count() > 0)
        {
            MaterialMessageBox.Show($"Невозможно закрыть кассовую смену, в которой есть открытые заказы.",
                                    false,
                                    FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }

        try
        { Client.CloseCafeShift(); }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            MaterialMessageBox.Show($"Ошибка: {ex}.",
                                    false,
                                    FlexibleMaterialForm.ButtonsPosition.Center);
        }
    }

    private void MainFormTabController_Selecting(object sender, TabControlCancelEventArgs e)
    {
        TabPage currentPage = (sender as TabControl).SelectedTab;
        if (currentPage.Name.Equals(nameof(CreateOrderPage)))
            UpdateTableLayoutPanel(Client.TableOperation.GetTables());
        if (currentPage.Name.Equals(nameof(OrdersPage)))
            UpdateOrdersLayoutPanel(Client.OrderOperation.GetOrders());
    }

    private void UpdateOrdersLayoutPanel(IEnumerable<Order> orders)
    {
        OpenOrderLayoutPanel.Controls.Clear();

        List<TableLayoutPanel> panels = new();
        foreach (var order in orders)
        {
            TableLayoutPanel panel = new();

            panel.RowStyles.Add(new RowStyle(SizeType.Percent));
            MaterialButton button = new();
            button.Click += (sender, e) => OpenOrder(sender, e, order.Id);
            button.Text = $"GuestCount: {order.GetGuests().Count()}\n" +
                          $"TableNumber: {order.Table.TableNumber}\n" +
                          $"Waiter: {order.Waiter.Name}\n" +
                          $"Sum: {order.Sum}";
            button.Dock = DockStyle.Fill;
            panel.Controls.Add(button);

            panel.RowStyles.Add(new RowStyle(SizeType.Percent));
            MaterialListView view = new();
            view.Columns.Add("Products");
            foreach (var products in order.GetGuests().Select(x => x.GetProducts()))
                foreach (var product in products)
                    view.Items.Add(product.ProductName);
            view.Dock = DockStyle.Fill;
            panel.Controls.Add(view);

            panels.Add(panel);
        }

        OpenOrderLayoutPanel.Controls.AddRange(panels.ToArray());
    }

    private void UpdateTableLayoutPanel(IEnumerable<Table> source)
    {
        CreateOrderLayoutPanel.Controls.Clear();

        List<MaterialButton> buttons = new();
        foreach (var item in source)
        {
            MaterialButton button = new();
            button.Click += (sender, e) => CreateOrder(sender, e, item.Id);
            button.Text = $"Стол #{item.TableNumber}";
            button.Dock = DockStyle.Fill;
            buttons.Add(button);
        }

        CreateOrderLayoutPanel.Controls.AddRange(buttons.OrderBy(x => x.Text).ToArray());
    }

    private void OpenOrder(object sender, EventArgs e, Guid orderId) =>
        new OrderForm(Client, orderId).Show();

    private void CreateOrder(object sender, EventArgs e, Guid tableId)
    {
        var table = Client.GetByCacheOperation.GetTable().GetTableById(tableId);
        var order = Client.OrderOperation.CreateOrder(Credentials, table);
        new OrderForm(Client, order.Id).Show();
    }
}
