using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Helper;

namespace Office.Forms;

public partial class MainForm : MaterialForm
{
    public Client Client { get; }

    public MainForm(Client client)
    {
        InitializeComponent();
        Client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
        var q = Client.AllCache;
    }
}