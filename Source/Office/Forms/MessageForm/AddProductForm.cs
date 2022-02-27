using MaterialSkin.Controls;
using Office.Helper;
using Storage.Entities.Implementation;
using System;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class AddProductForm : MaterialForm
{
    public AddProductForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    public Product GetNewProduct() =>
        ShowDialog() is DialogResult.OK ? CreateProduct(ProductNameTextBox.Text, decimal.Parse(PriceTextBox.Text), IsItForSaleCheckBox.Checked) : default;

    private Product CreateProduct(string productName, decimal price, bool isItForSale) =>
        new(Guid.NewGuid(), productName, price, isItForSale);

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ProductNameTextBox.Text) || string.IsNullOrEmpty(PriceTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}