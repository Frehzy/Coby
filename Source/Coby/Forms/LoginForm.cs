using Coby.ClientOperation;
using Coby.Forms.Face;
using MaterialSkin.Controls;
using Office.Helper;
using System;

namespace Coby.Forms;

public partial class LoginForm : MaterialForm
{
    private readonly IClient _client;

    public LoginForm(IClient client)
    {
        InitializeComponent();
        _client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
        FormHelper.SetFullScreen(this);
    }

    private void LoginByPinButton_Click(object sender, EventArgs e)
    {
        string password = PasswordTextBox.Text;
        if (string.IsNullOrEmpty(password))
        {
            MaterialMessageBox.Show($"Поле с паролем не может быть пустым.", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }

        if (_client.LicenseOperation.GetCredentials(password, out var credentials) is null)
        {
            MaterialMessageBox.Show($"Пароль не найден. {password}", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }
        new MainForm(_client, credentials).Show();
        Hide();
    }

    private void LoginByFaceButton_Click(object sender, EventArgs e)
    {
        Enabled = false;
        var credentials = new FaceDetectionForm(_client).GetCredentials();
        Enabled = true;
        if (credentials is null)
            return;

        new MainForm(_client, credentials).Show();
        Hide();
    }

    private void FaceDetectSettingsButton_Click(object sender, EventArgs e)
    {
        var settingsForm = new FaceDetectionSettingsForm();
        settingsForm.Show();
        Enabled = false;
        settingsForm.FormClosing += (sender, e) => { Enabled = true; };
    }

    private void ExitButton_Click(object sender, EventArgs e) =>
        Environment.Exit(0);
}