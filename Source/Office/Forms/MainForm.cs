using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Forms.MessageForm;
using Office.Forms.MessageForm.Face;
using Office.Forms.StatisticsPage;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Linq;

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
        DataGridHelper.FillTable(WaitersDgv, Client.GetByCacheOperation.Waiter.GetWaiters());

    private void AddWaiterButton_Click(object sender, EventArgs e)
    {
        _ = new AddWaiterForm().GetNewWaiter(Client.Creater.CreateWaiter);
        UpdateWaitersButton.PerformClick();
    }

    private void AddWaiterFaceButton_Click(object sender, EventArgs e)
    {
        var waiterId = new RowHelper<Guid>(WaitersDgv).GetValueByColumnName("Id", false).Value;
        new AddWaiterFaceForm(waiterId, Client).Show();
    }

    private void DeleteWaiterButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(WaitersDgv).GetValueByColumnName();
        if (result is not null)
            Client.Remover.RemoveWaiterById(result.Value);

        UpdateWaitersButton.PerformClick();
    }

    private void TableUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(TablesDgv, Client.GetByCacheOperation.Table.GetTables());

    private void AddTableButton_Click(object sender, EventArgs e)
    {
        _ = new AddTableForm().GetNewTable(Client.Creater.CreateTable);
        TableUpdateButton.PerformClick();
    }

    private void RemoveTableButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(TablesDgv).GetValueByColumnName();
        if (result is not null)
            Client.Remover.RemoveTableById(result.Value);

        TableUpdateButton.PerformClick();
    }

    private void ProductUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(ProductsDgv, Client.GetByCacheOperation.Product.GetProducts());

    private void AddProductButton_Click(object sender, EventArgs e)
    {
        _ = new AddProductForm().GetNewProduct(Client.Creater.CreateProduct);
        ProductUpdateButton.PerformClick();
    }

    private void RemoveProductButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(ProductsDgv).GetValueByColumnName();
        if (result is not null)
        {
            var product = Client.GetByCacheOperation.Product.GetProductById(result.Value);
            Client.Remover.RemoveProductById(result.Value);
            if (product.IsItForSale is true)
                Client.GetByCacheOperation.GetNomenclatureOperation.GetNomenclatures()
                                        .Where(x => x.ParentId.Equals(result))
                                        .Select(x => Client.Remover.RemoveNomenclatureByParentAndChildId(result.Value, x.ChildId));
            else
                Client.Remover.RemoveNomenclatureByChildId(result.Value);
        }

        ProductUpdateButton.PerformClick();
    }

    private void OpenNomenclature_Click(object sender, EventArgs e)
    {
        var parentId = new RowHelper<Guid>(ProductsDgv).GetIdBySelectedRow("Id");

        var parentProduct = Client.GetByCacheOperation.Product.GetProductById(parentId);
        if (parentProduct.IsItForSale is true)
            new NomenclatureForm(Client, parentProduct).Show();
        else
            MaterialMessageBox.Show("Продукт не для продажи не может иметь номенклатуры");
    }

    private void PaymentTypeUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(PaymentTypesDgv, Client.GetByCacheOperation.PaymentType.GetPaymentTypes());

    private void AddPaymentTypeButton_Click(object sender, EventArgs e)
    {
        _ = new AddPaymentTypeForm().GetNewPaymentType(Client.Creater.CreatePaymentType);
        PaymentTypeUpdateButton.PerformClick();
    }

    private void RemovePaymentTypeButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(PaymentTypesDgv).GetValueByColumnName();
        if (result is not null)
            Client.Remover.RemovePaymentTypeById(result.Value);

        PaymentTypeUpdateButton.PerformClick();
    }

    private void CloseOrdersButton_Click(object sender, EventArgs e)
    {
        Func<List<Order>> func = Client.GetCloseOrders.Invoke;
        new OrdersForm(Client, func).Show();
    }

    private void CurrentSessionButton_Click(object sender, EventArgs e)
    {
        Func<List<Order>> func = Client.GetByCacheOperation.Order.GetOrders;
        new OrdersForm(Client, func).Show();
    }

    private void ChartsButton_Click(object sender, EventArgs e) =>
        new ChartsForm(Client).Show();

    private void ReportButton_Click(object sender, EventArgs e) =>
        new ReportsForm(Client).Show();
}