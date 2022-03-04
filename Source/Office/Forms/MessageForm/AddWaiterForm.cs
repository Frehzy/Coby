using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.Operations.CreateRemove;
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

    public Waiter GetNewWaiter(Creater creater) =>
        ShowDialog() is DialogResult.OK ? creater.CreateWaiter(UsernameTextBox.Text, PasswordTextBox.Text) : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}