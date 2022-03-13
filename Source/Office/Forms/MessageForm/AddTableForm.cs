using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
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

    public Table GetNewTable(Func<int, Table> createTable) =>
        ShowDialog() is DialogResult.OK ? createTable(int.Parse(TableNumberTextBox.Text)) : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TableNumberTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}