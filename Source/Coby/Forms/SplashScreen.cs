using MaterialSkin.Controls;
using Office.Helper;
using System;
using System.Runtime.InteropServices;

namespace Coby.Forms;

public partial class SplashScreen : MaterialForm
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
                                                     int nTopRect,
                                                     int RightRect,
                                                     int nBottomRect,
                                                     int nWidthEllipse,
                                                     int nHeightEllipse);

    public SplashScreen()
    {
        InitializeComponent();
        _ = FormHelper.CreateMaterialSkinManager(this);
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        ProgressBar.SetColor(BackColor);
        ProgressBar.StartProgressBar();
    }

    private void SplashScreen_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) =>
        ProgressBar.StopProgressBar();
}