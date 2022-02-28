using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.Operations.WaiterOperation;
using System;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class AddWaiterForm : MaterialForm
{
    public AddWaiterForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    public Waiter GetNewWaiter(WaiterOperation waiterOperation) =>
        ShowDialog() is DialogResult.OK ? waiterOperation.CreateWaiter(UsernameTextBox.Text, PasswordTextBox.Text) : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}