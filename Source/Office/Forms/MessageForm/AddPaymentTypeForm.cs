using MaterialSkin.Controls;
using Office.Helper;
using Storage.Entities.Implementation;
using System;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class AddPaymentTypeForm : MaterialForm
{
    public AddPaymentTypeForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    public PaymentType GetNewPaymentType() =>
        ShowDialog() is DialogResult.OK ? CreatePaymentType(PaymentTypeTextBox.Text) : default;

    private PaymentType CreatePaymentType(string name) =>
        new(Guid.NewGuid(), name);

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PaymentTypeTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}