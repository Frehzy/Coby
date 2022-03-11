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

    public Credentials Credentials { get; }

    public CreateOrderForm(IClient client, Credentials credentials)
    {
        InitializeComponent();
        Client = client;
        Credentials = credentials;
        _ = FormHelper.CreateMaterialSkinManager(this);
        FormHelper.SetFullScreen(this);
        UpdateTableLayoutPanel(Client.TableOperation.GetTables());
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

        void CreateOrder(object sender, EventArgs e, Guid tableId)
        {
            var table = Client.GetByCacheOperation.Table.GetTableById(tableId);
            var order = Client.OrderOperation.CreateOrder(Credentials, table);
            Close();
        }
    }

    private void BackButton_Click(object sender, EventArgs e) => Close();
}