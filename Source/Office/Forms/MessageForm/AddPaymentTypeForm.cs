using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Storage.Operations.CreateRemove;
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

    public PaymentType GetNewPaymentType(Creater creater) =>
        ShowDialog() is DialogResult.OK ? creater.CreatePaymentType(PaymentTypeTextBox.Text) : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PaymentTypeTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}