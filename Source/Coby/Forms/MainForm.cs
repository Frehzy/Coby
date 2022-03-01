using Coby.ClientOperation;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Storage.Operations.WaiterOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class MainForm : MaterialForm
{
    public IClient Client { get; }

    public Waiter Waiter { get; private set; }

    public Credentials Credentials { get; }

    public MainForm(IClient client, Credentials credentials)
    {
        InitializeComponent();
        Client = client;
        Credentials = credentials;
        Waiter = Client.WaiterOperation.GetWaiterById(Credentials.WaiterId);
        AfterUpdateStatus();
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void ChangePersonalShiftStatus_Click(object sender, EventArgs e)
    {
        Waiter = Waiter.Status is WaiterSessionStatus.Open
            ? Client.WaiterOperation.ClosePersonalShift(Waiter.Id)
            : Client.WaiterOperation.OpenPersonalShift(Waiter.Id);
        AfterUpdateStatus();
        MaterialMessageBox.Show($"Личная смена имеет статус: {Waiter.Status}", false, FlexibleMaterialForm.ButtonsPosition.Center);
    }

    private void AfterUpdateStatus()
    {
        if (Waiter.Status is WaiterSessionStatus.Open)
        {
            ChangeControlEnable(CreateOrderPage.Controls, true);
            ChangeControlEnable(OrdersPage.Controls, true);
            PersonalShiftController.Text = "Закрыть личную смену";
        }
        else
        {
            MainFormTabController.SelectTab(OptionsPage);
            ChangeControlEnable(CreateOrderPage.Controls, false);
            ChangeControlEnable(OrdersPage.Controls, false);
            PersonalShiftController.Text = "Открыть личную смену";
        }

        static void ChangeControlEnable(Control.ControlCollection controls, bool status)
        {
            foreach (Control control in controls)
                control.Enabled = status;
        }
    }

    private void LockButton_Click(object sender, EventArgs e)
    {
        new LoginForm(Client).Show();
        Hide();
    }
}
