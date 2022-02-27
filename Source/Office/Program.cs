using Office.ClientOperation;
using Office.Forms;
using System;
using System.Windows.Forms;

namespace Office;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var client = new Client();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm(client));
    }
}