using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.Operations.CreateRemove;
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
        ComboBoxSet(products.OrderBy(x => x.ProductName));
        SelectedItem = ChildProductComboBox.Items.Count > 0
            ? (Product)ChildProductComboBox.Items[0]
            : default;
    }

    public Nomenclature GetNewNomenclature(Creater creater) =>
        ShowDialog() is DialogResult.OK
        ? creater.CreateNomenclature(_parentId, SelectedItem.Id, decimal.Parse(AmountTextBox.Text))
        : default;

    private void ComboBoxSet(IEnumerable<Product> products)
    {
        ChildProductComboBox.DataSource = products.ToList();
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