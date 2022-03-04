using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.Operations;
using Storage.Operations.CreateRemove;
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

    public Product GetNewProduct(Creater creater) =>
        ShowDialog() is DialogResult.OK ? creater.CreateProduct(ProductNameTextBox.Text, decimal.Parse(PriceTextBox.Text), IsItForSaleCheckBox.Checked) : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ProductNameTextBox.Text) || string.IsNullOrEmpty(PriceTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}