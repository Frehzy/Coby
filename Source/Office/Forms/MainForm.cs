using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Forms.MessageForm;
using Office.Helper;
using System;
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
        DataGridHelper.FillTable(WaitersDgv, Client.WaitersCache.GetWaitersCache());

    private void AddWaiterButton_Click(object sender, EventArgs e)
    {
        _ = new AddWaiterForm().GetNewWaiter(Client.WaiterOperation);
        UpdateWaitersButton.PerformClick();
    }

    private void DeleteWaiterButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(WaitersDgv).RemoveRow();
        if (result is not null)
            Client.WaitersCache.RemoveWaiter(result.Value);

        UpdateWaitersButton.PerformClick();
    }

    private void TableUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(TablesDgv, Client.TablesCache.GetTablesCache());

    private void AddTableButton_Click(object sender, EventArgs e)
    {
        _ = new AddTableForm().GetNewTable(Client.TableOperation);
        TableUpdateButton.PerformClick();
    }

    private void RemoveTableButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(TablesDgv).RemoveRow();
        if (result is not null)
            Client.TablesCache.RemoveTable(result.Value);

        TableUpdateButton.PerformClick();
    }

    private void ProductUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(ProductsDgv, Client.ProductsCache.GetProductsCache());

    private void AddProductButton_Click(object sender, EventArgs e)
    {
        _ = new AddProductForm().GetNewProduct(Client.ProductOperation);
        ProductUpdateButton.PerformClick();
    }

    private void RemoveProductButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(ProductsDgv).RemoveRow();
        if (result is not null)
        {
            Client.ProductsCache.RemoveProduct(result.Value);
            Client.NomenclatureCache.GetNomenclaturesCache()
                                    .Where(x => x.ParentId.Equals(result))
                                    .Select(x => Client.NomenclatureCache.RemoveNomenclature(result.Value, x.ChildId));
        }

        ProductUpdateButton.PerformClick();
    }

    private void OpenNomenclature_Click(object sender, EventArgs e)
    {
        var parentId = new RowHelper<Guid>(ProductsDgv).GetIdBySelectedRow("Id");

        var parentProduct = Client.ProductsCache.GetProductsCache().First(x => x.Id.Equals(parentId));
        if (parentProduct.IsItForSale is true)
            new NomenclatureForm(Client, parentProduct).Show();
        else
            MaterialMessageBox.Show("Продукт не для продажи не может иметь номенклатуры");
    }

    private void PaymentTypeUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(PaymentTypesDgv, Client.PaymentTypesCache.GetPaymentTypesCache());

    private void AddPaymentTypeButton_Click(object sender, EventArgs e)
    {
        _ = new AddPaymentTypeForm().GetNewPaymentType(Client.PaymentOperation);
        PaymentTypeUpdateButton.PerformClick();
    }

    private void RemovePaymentTypeButton_Click(object sender, EventArgs e)
    {
        var result = new RowHelper<Guid>(PaymentTypesDgv).RemoveRow();
        if (result is not null)
            Client.PaymentTypesCache.RemovePaymentType(result.Value);

        PaymentTypeUpdateButton.PerformClick();
    }
}