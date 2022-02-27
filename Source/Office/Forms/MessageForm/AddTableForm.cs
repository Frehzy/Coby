﻿using MaterialSkin.Controls;
using Office.Helper;
using Storage.Entities.Implementation;
using System;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class AddTableForm : MaterialForm
{
    public AddTableForm()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    public Table GetNewTable() =>
        ShowDialog() is DialogResult.OK ? CreateTable(TableNumberTextBox.Text) : default;

    private Table CreateTable(string tableNumber) =>
        new(Guid.NewGuid(), int.Parse(tableNumber));

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TableNumberTextBox.Text))
            return;
        DialogResult = DialogResult.OK;
        Close();
    }
}