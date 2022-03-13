using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
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

    public Waiter GetNewWaiter(Func<string, string, PermissionStatus, Waiter> createWaiter) =>
        ShowDialog() is DialogResult.OK
        ? createWaiter(
            UsernameTextBox.Text,
            PasswordTextBox.Text,
            AdminCheckBox.Checked ? PermissionStatus.Admin : PermissionStatus.Waiter)
        : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}