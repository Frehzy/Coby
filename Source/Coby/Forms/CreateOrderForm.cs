using Coby.ClientOperation;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class CreateOrderForm : MaterialForm
{
    public IClient Client { get; }

    public List<Order> Orders { get; }

    public Credentials Credentials { get; }

    public CreateOrderForm(IClient client, Credentials credentials)
    {
        InitializeComponent();
        Client = client;
        Orders = client.GetByCacheOperation.Order.GetOrders();
        Credentials = credentials;
        _ = FormHelper.CreateMaterialSkinManager(this);
        FormHelper.SetFullScreen(this);
        UpdateTableLayoutPanel(Client.TableOperation.GetTables());
    }

    private void UpdateTableLayoutPanel(IEnumerable<Table> source)
    {
        CreateOrderLayoutPanel.Controls.Clear();
        IEnumerable<Order> orderOnTable = default;

        List<MaterialButton> buttons = new();
        foreach (var item in source)
        {
            MaterialButton button = new();
            button.Click += (sender, e) => CreateOrder(sender, e, item.Id);
            button.Text = $"Table #{item.TableNumber}";
            button.Tag = item.TableNumber;
            button.Dock = DockStyle.Fill;
            buttons.Add(button);

            orderOnTable = Orders.Where(x => x.Table.Id.Equals(item.Id));
            if (orderOnTable.Count() > 0)
                button.Text += string.Concat(Environment.NewLine, $"Count of orders on this table: {orderOnTable.Count()}");
        }

        CreateOrderLayoutPanel.Controls.AddRange(buttons.OrderBy(x => int.Parse(x.Tag.ToString())).ToArray());

        void CreateOrder(object sender, EventArgs e, Guid tableId)
        {
            var table = Client.GetByCacheOperation.Table.GetTableById(tableId);
            var order = Client.OrderOperation.CreateOrder(Credentials, table);
            Close();
        }
    }

    private void BackButton_Click(object sender, EventArgs e) => Close();
}