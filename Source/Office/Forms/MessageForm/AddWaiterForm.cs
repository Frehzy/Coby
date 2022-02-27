using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enums;
using Storage.Entities.Implementation;
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

    public Waiter GetNewWaiter() =>
        ShowDialog() is DialogResult.OK ? CreateWaiter(UsernameTextBox.Text, PasswordTextBox.Text) : default;

    private Waiter CreateWaiter(string username, string password) =>
        new(Guid.NewGuid(), username, password, WaiterSessionStatus.Closed);

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}