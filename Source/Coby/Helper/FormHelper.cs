using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Runtime.InteropServices;
using static MaterialSkin.MaterialSkinManager;

namespace Office.Helper;

internal static class FormHelper
{
    private const int SM_CXSCREEN = 0;
    private const int SM_CYSCREEN = 1;
    private static readonly IntPtr HWND_TOP = IntPtr.Zero;
    private const int SWP_SHOWWINDOW = 64; // 0x0040
    private static int ScreenX => GetSystemMetrics(SM_CXSCREEN);
    private static int ScreenY => GetSystemMetrics(SM_CYSCREEN);

    public static MaterialSkinManager CreateMaterialSkinManager(MaterialForm form)
    {
        MaterialSkinManager manager = Instance;
        manager.EnforceBackcolorOnAllComponents = true;
        manager.AddFormToManage(form);
        manager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey50, Accent.Red200, TextShade.WHITE);
        manager.Theme = Themes.DARK;

        return manager;
    }

    public static void SetFullScreen(MaterialForm targetForm) =>
        SetWindowPos(targetForm.Handle, HWND_TOP, 0, 0, ScreenX, ScreenY, SWP_SHOWWINDOW);

    [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
    public static extern int GetSystemMetrics(int which);

    [DllImport("user32.dll")]
    public static extern void SetWindowPos(IntPtr hwnd,
                                           IntPtr hwndInsertAfter,
                                           int X,
                                           int Y,
                                           int width,
                                           int height,
                                           uint flags);
}