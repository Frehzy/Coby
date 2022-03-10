using Coby.ClientOperation;
using MaterialSkin.Controls;
using Office.Helper;
using System;

namespace Coby.Forms;

public partial class LoginForm : MaterialForm
{
    public IClient Client { get; }

    public LoginForm(IClient client)
    {
        InitializeComponent();
        Client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
        FormHelper.SetFullScreen(this);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        string password = PasswordTextBox.Text;
        if (string.IsNullOrEmpty(password))
        {
            MaterialMessageBox.Show($"Поле с паролем не может быть пустым.", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }

        if (Client.LicenseOperation.GetCredentials(password, out var credentials) is null)
        {
            MaterialMessageBox.Show($"Пароль не найден. {password}", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }
        new MainForm(Client, credentials).Show();
        Hide();
    }

    private void ExitButton_Click(object sender, EventArgs e) =>
        Environment.Exit(0);
}