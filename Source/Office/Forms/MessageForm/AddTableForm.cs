using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.Operations.TableOperation;
using System;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class AddTableForm : MaterialForm
{
    public AddTableForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    public Table GetNewTable(TableOperation tableOperation) =>
        ShowDialog() is DialogResult.OK ? tableOperation.CreateTable(int.Parse(TableNumberTextBox.Text)) : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TableNumberTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}