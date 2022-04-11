using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using System;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class AddPaymentTypeForm : MaterialForm
{
    public AddPaymentTypeForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
        PaymentEnumComboBox.DataSource = Enum.GetValues(typeof(PaymentEnum));
    }

    public PaymentType GetNewPaymentType(Func<string, PaymentEnum, PaymentType> createPaymentType) =>
        ShowDialog() is DialogResult.OK
        ? createPaymentType(PaymentTypeTextBox.Text, (PaymentEnum)PaymentEnumComboBox.SelectedItem)
        : default;

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(PaymentTypeTextBox.Text) || PaymentEnumComboBox.SelectedItem is null)
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}