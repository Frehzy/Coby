using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
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

    public Product GetNewProduct(Func<string, decimal, bool, Product> createProduct) =>
        ShowDialog() is DialogResult.OK ? createProduct(ProductNameTextBox.Text, decimal.Parse(PriceTextBox.Text), IsItForSaleCheckBox.Checked) : default;

    public void DisableCheckBox() =>
        IsItForSaleCheckBox.Enabled = false;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ProductNameTextBox.Text) || string.IsNullOrEmpty(PriceTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}