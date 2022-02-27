using MaterialSkin.Controls;
using Office.Helper;
using Storage.Entities.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class AddNomenclatureForm : MaterialForm
{
    private readonly Guid _parentId;
    private Product SelectedItem;

    public AddNomenclatureForm(Guid parentId, IEnumerable<Product> products)
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
        _parentId = parentId;
        ComboBoxSet(products.ToList());
    }

    public Nomenclature GetNewNomenclature() =>
        ShowDialog() is DialogResult.OK ? CreateNomenclature(SelectedItem.Id, decimal.Parse(AmountTextBox.Text)) : default;

    private Nomenclature CreateNomenclature(Guid childId, decimal amount) =>
        new(_parentId, childId, amount);

    private void ComboBoxSet(List<Product> products)
    {
        ChildProductComboBox.DataSource = products;
        ChildProductComboBox.DisplayMember = "ProductName";

        ChildProductComboBox.SelectedIndexChanged += ChildProductComboBox_SelectedIndexChanged;
    }

    private void ChildProductComboBox_SelectedIndexChanged(object sender, EventArgs e) =>
        SelectedItem = (Product)ChildProductComboBox.SelectedItem;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(AmountTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}