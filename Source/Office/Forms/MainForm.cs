using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Forms.MessageForm;
using Office.Helper;
using System;

namespace Office.Forms;

public partial class MainForm : MaterialForm
{
    public IClient Client { get; }

    public MainForm(IClient client)
    {
        InitializeComponent();
        Client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void UpdateWaitersButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(WaitersDgv, Client.WaitersCache.GetWaitersCache());

    private void AddWaiterButton_Click(object sender, EventArgs e)
    {
        var waiter = new AddWaiterForm().GetNewWaiter();
        if (waiter is not null)
            Client.WaitersCache.AddWaiter(waiter);

        UpdateWaitersButton.PerformClick();
    }

    private void DeleteWaiterButton_Click(object sender, EventArgs e)
    {
        var result = new RemoveRow(WaitersDgv).GetIdBySelectedRow();
        if (result is not null)
            Client.WaitersCache.RemoveWaiter(result.Id);

        UpdateWaitersButton.PerformClick();
    }

    private void TableUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(TablesDgv, Client.TablesCache.GetTablesCache());

    private void AddTableButton_Click(object sender, EventArgs e)
    {
        var table = new AddTableForm().GetNewTable();
        if (table is not null)
            Client.TablesCache.AddTable(table);

        TableUpdateButton.PerformClick();
    }

    private void RemoveTableButton_Click(object sender, EventArgs e)
    {
        var result = new RemoveRow(TablesDgv).GetIdBySelectedRow();
        if (result is not null)
            Client.TablesCache.RemoveTable(result.Id);

        TableUpdateButton.PerformClick();
    }

    private void PaymentTypeUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(PaymentTypesDgv, Client.PaymentTypesCache.GetPaymentTypesCache());

    private void AddPaymentTypeButton_Click(object sender, EventArgs e)
    {
        var paymentType = new AddPaymentTypeForm().GetNewPaymentType();
        if (paymentType is not null)
            Client.PaymentTypesCache.AddPaymentType(paymentType);

        PaymentTypeUpdateButton.PerformClick();
    }

    private void RemovePaymentTypeButton_Click(object sender, EventArgs e)
    {
        var result = new RemoveRow(PaymentTypesDgv).GetIdBySelectedRow();
        if (result is not null)
            Client.PaymentTypesCache.RemovePaymentType(result.Id);

        PaymentTypeUpdateButton.PerformClick();
    }
}