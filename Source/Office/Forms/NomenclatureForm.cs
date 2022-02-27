using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Forms.MessageForm;
using Office.Helper;
using Storage.Entities.Implementation;
using System;
using System.Linq;

namespace Office.Forms;

public partial class NomenclatureForm : MaterialForm
{
    public IClient Client { get; }

    public Product Product { get; }

    public NomenclatureForm(IClient client, Product product)
    {
        InitializeComponent();
        Client = client;
        Product = product;
        _ = FormHelper.CreateMaterialSkinManager(this);
        LoadParentInfo();
    }

    private void LoadParentInfo()
    {
        foreach (var property in Product.GetType().GetProperties())
            ParentInfoTextBox.Text += $"{property.Name}: {property.GetValue(Product, null)}" + Environment.NewLine;
    }

    private void NomenclatureUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(NomenclatureDgv, Client.NomenclatureCache.GetNomenclaturesCache().Where(x => x.ParentId.Equals(Product.Id)));

    private void AddNomenclatureButton_Click(object sender, EventArgs e)
    {
        var nomenclature = new AddNomenclatureForm(Product.Id, Client.ProductsCache.GetProductsCache().Where(x => x.IsItForSale is false)).GetNewNomenclature();
        if (nomenclature is not null)
            Client.NomenclatureCache.AddNomenclature(nomenclature);

        NomenclatureUpdateButton.PerformClick();
    }
}
