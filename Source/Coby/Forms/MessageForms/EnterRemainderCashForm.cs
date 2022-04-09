﻿using MaterialSkin.Controls;
using Office.Helper;
using System;
using System.Windows.Forms;

namespace Coby.Forms.MessageForms;

public partial class EnterRemainderCashForm : MaterialForm
{
    public EnterRemainderCashForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    public decimal GetRemainderCash() =>
        ShowDialog() is DialogResult.OK
        ? decimal.Parse(CashBalanceTextBox.Text)
        : default;

    private void EnterPinButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(CashBalanceTextBox.Text) is true && decimal.TryParse(CashBalanceTextBox.Text, out _) is false)
            return;

        DialogResult = DialogResult.OK;
        Close();
    }
}