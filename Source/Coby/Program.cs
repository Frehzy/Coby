using Coby.ClientOperation;
using Coby.Forms;
using Shared;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace Coby;

internal static class Program
{
    const int WM_USER = 0x0400;

    static void Main()
    {
        var client = CreateClient();
        RestartExplorer();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LoginForm(client));
    }

    static IClient CreateClient()
    {
        while (true)
        {
            try
            {
                return new Client();
            }
            catch (EndpointNotFoundException ex)
            {
                Log.Error($"Failed to instantiate client. Exception: {ex}");
            }
            catch (Exception ex)
            {
                Log.Error($"Unknown exception: {ex}");
            }
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }

    static void RestartExplorer()
    {
        try
        {
            var ptr = FindWindow("Shell_TrayWnd", null);
            PostMessage(ptr, WM_USER + 436, (IntPtr)0, (IntPtr)0);

            do
            {
                ptr = FindWindow("Shell_TrayWnd", null);

                if (ptr.ToInt32() == 0)
                    break;

            } while (true);
        }
        catch (Exception ex)
        {
            Log.Error($"Exception restart explorer.\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}");
        }

        string explorer = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
        Process process = new Process();
        process.StartInfo.FileName = explorer;
        process.StartInfo.UseShellExecute = true;
        process.Start();
    }

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool PostMessage(IntPtr hWnd, [MarshalAs(UnmanagedType.U4)] uint Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", SetLastError = true)]
    static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
}