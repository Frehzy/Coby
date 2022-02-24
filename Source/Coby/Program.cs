using Coby.ClientOperation;
using System.Windows.Forms;

namespace Coby;

internal static class Program
{
    static void Main()
    {
        var client = new Client();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1(client));
    }
}