using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Windows.Forms;

namespace Coby.Forms.MessageForms;

public partial class EnterPinForm : MaterialForm
{
    public EnterPinForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    public Credentials GetCredentials(Func<string, Credentials> tryGetCredentials) =>
        ShowDialog() is DialogResult.OK
        ? tryGetCredentials(PinTextBox.Text)
        : default;

    private void AddPaymentButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PinTextBox.Text) is true)
            return;

        DialogResult = DialogResult.OK;
        Close();
    }
}