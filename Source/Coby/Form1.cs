using Coby.ClientOperation;
using System.Windows.Forms;

namespace Coby;

public partial class Form1 : Form
{
    public Form1(IClient client)
    {
        InitializeComponent();
    }
}