using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.Operations.PaymentOperation;
using System;
using System.Windows.Forms;

namespace Coby.Forms.MessageForms;

public partial class AddPaymentForm : MaterialForm
{
    public AddPaymentForm(string paymentTypeName)
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
        PaymentTypeTextBox.Text = paymentTypeName;
    }

    public Payment AddPayment(Credentials credentials, PaymentOperations paymentOperation, Guid paymentTypeId) =>
        ShowDialog() is DialogResult.OK
        ? paymentOperation.AddPaymentOnOrder(credentials, paymentTypeId, decimal.Parse(AmountTextBox.Text))
        : default;

    private void AddPaymentButton_Click(object sender, EventArgs e)
    {
        if (decimal.TryParse(AmountTextBox.Text, out var result) is false)
            return;
        if (result <= 0)
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}