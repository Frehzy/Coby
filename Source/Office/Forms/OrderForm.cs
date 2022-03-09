using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Helper;
using Shared.Dto.Enities;

namespace Office.Forms;

public partial class OrderForm : MaterialForm
{
    public IClient Client { get; }

    public Order Order { get; }

    public OrderForm(IClient client, Order order)
    {
        InitializeComponent();
        Client = client;
        Order = order;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }
}
