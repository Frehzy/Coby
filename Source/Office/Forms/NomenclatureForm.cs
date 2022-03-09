using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Forms.MessageForm;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Linq;
using System.Windows.Forms;

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
        LoadInfo(product, ParentInfoTextBox);
    }

    private void LoadInfo(Product product, MaterialMultiLineTextBox2 textBox)
    {
        var properties = product.GetType().GetProperties();
        var result = properties.Select(x => $"{x.Name}: {x.GetValue(product, null)}");
        textBox.Text = string.Join(Environment.NewLine, result);
    }

    private void NomenclatureUpdateButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(NomenclatureDgv, Client.GetByCacheOperation.GetNomenclatureOperation().GetNomenclaturesByParentId(Product.Id));

    private void AddNomenclatureButton_Click(object sender, EventArgs e)
    {
        _ = new AddNomenclatureForm(Product.Id,
                                    Client.GetByCacheOperation.GetProduct()
                                    .GetProducts()
                                    .Where(x => x.IsItForSale is false)).GetNewNomenclature(Client.Creater);
        NomenclatureUpdateButton.PerformClick();
    }

    private void RemoveNomenclatureButton_Click(object sender, EventArgs e)
    {
        var parentId = new RowHelper<Guid>(NomenclatureDgv).GetValueByColumnName("ParentId");
        var childId = new RowHelper<Guid>(NomenclatureDgv).GetValueByColumnName("ChildId", false);
        if (parentId is not null && childId is not null)
            Client.Remover.RemoveNomenclatureByParentAndChildId(parentId.Value, childId.Value);

        NomenclatureUpdateButton.PerformClick();
    }

    private void NomenclatureDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var childId = new RowHelper<Guid>(NomenclatureDgv).GetValueByColumnName("ChildId", false);
        if (childId is not null)
            LoadInfo(Client.GetByCacheOperation.GetProduct().TryGetProductById(childId.Value), ChildInfoTextBox);
    }
}
