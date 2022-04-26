using Coby.ClientOperation;
using Coby.Forms.Face;
using Coby.Forms.MessageForms;
using MaterialSkin.Controls;
using Office.Helper;
using Shared;
using Shared.Dto.Enums;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Coby.Forms;

public partial class LoginForm : MaterialForm
{
    private readonly IClient _client;
    private const int WM_USER = 0x0400;

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

        var credentials = _client.LicenseOperation.TryGetCredentials(password);
        if (credentials is null)
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
        var credentials = new FaceDetectionForm(_client).TryGetCredentials();
        Enabled = true;
        if (credentials is null)
            return;

        new MainForm(_client, credentials).Show();
        Hide();
    }

    private void FaceDetectSettingsButton_Click(object sender, EventArgs e)
    {
        var credentials = new EnterPinForm().GetCredentials(_client.LicenseOperation.TryGetCredentials);
        if (credentials is null)
        {
            MaterialMessageBox.Show($"Пароль не найден.", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }
        if (_client.GetByCacheOperation.Waiter.GetWaiterById(credentials.WaiterId).PermissionStatus is not PermissionStatus.Admin)
        {
            MaterialMessageBox.Show($"Недостаточно прав.", false, FlexibleMaterialForm.ButtonsPosition.Center);
            return;
        }

        var settingsForm = new FaceDetectionSettingsForm();
        settingsForm.Show();
        Enabled = false;
        settingsForm.FormClosing += (sender, e) => { Enabled = true; };
    }

    private void ExitButton_Click(object sender, EventArgs e) =>
        Environment.Exit(0);

    private void RestartExplorerButton_Click(object sender, EventArgs e)
    {
        try
        {
            var ptr = FindWindow("Shell_TrayWnd", null);
            PostMessage(ptr, WM_USER + 436, (IntPtr)0, (IntPtr)0);
        }
        catch (Exception ex)
        {
            Log.Error($"Exception restart explorer.\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}");
        }

        string explorer = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
        Process process = new();
        process.StartInfo.FileName = explorer;
        process.StartInfo.UseShellExecute = true;
        process.Start();
    }

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool PostMessage(IntPtr hWnd, [MarshalAs(UnmanagedType.U4)] uint Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
}