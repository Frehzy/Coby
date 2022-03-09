using Coby.ClientOperation;
using Coby.Forms.CustomControls.CardView;
using Coby.Forms.CustomControls.CardView.Anim;
using MaterialSkin.Controls;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Coby.Forms;

public partial class CloseOrdersForm : MaterialForm
{
    private int _page;

    public IClient Client { get; }

    public List<Order> CloseOrders { get; }

    public int Page
    {
        get => _page;
        set
        {
            int cellCount = CloseOrdersTableLayout.ColumnCount * CloseOrdersTableLayout.RowCount;
            if (value >= 0 && value <= Math.Ceiling((decimal)(CloseOrders.Count() / cellCount)))
                _page = value;
        }
    }

    public CloseOrdersForm(IClient client, IEnumerable<Order> closeOrders)
    {
        InitializeComponent();
        Client = client;
        CloseOrders = closeOrders.ToList();
        _ = FormHelper.CreateMaterialSkinManager(this);
        UpdateOrdersLayoutPanel(Page);
        Animator.Start();
    }

    private void UpdateOrdersLayoutPanel(int page)
    {
        CloseOrdersTableLayout.Controls.Clear();

        int cellCount = CloseOrdersTableLayout.ColumnCount * CloseOrdersTableLayout.RowCount;
        var orders = CloseOrders.Skip(cellCount * page).Take(cellCount);

        List<CustomCardView> cardViews = new();
        foreach (var order in orders)
        {
            CustomCardView view = new();
            view.SetColorAndFont(BackColor, Font);
            view.TextHeader = $"Table {order.Table.TableNumber}";
            view.Text = "More information";
            string products = string.Join(string.Format("{0}-", Environment.NewLine), order.GetGuests()
                                                                                           .SelectMany(x => x.GetProducts())
                                                                                           .Take(10)
                                                                                           .Select(x => x.ProductName));
            view.TextDescrition = $"GuestCount: {order.GetGuests().Count()}\n" +
                                  $"Sum: {order.Sum}\n" +
                                  $"StartTime: {order.StartTime}\n" +
                                  $"Products: \n-{products}";
            view.MouseClick += (sender, e) => OpenOrder(sender, e, order.Id, view.CurtainHeight);
            view.Dock = DockStyle.Fill;

            cardViews.Add(view);
        }

        CloseOrdersTableLayout.Controls.AddRange(cardViews.OrderBy(x => x.Name).ToArray());

        void OpenOrder(object sender, MouseEventArgs e, Guid orderId, int y)
        {
            if (e.Y <= y)
            {
                Enabled = false;
                var orderForm = new OrderForm(Client, orderId);
                orderForm.Show();

                orderForm.FormClosed += (sender, e) =>
                {
                    Enabled = true;
                    Page = 0;
                    UpdateOrdersLayoutPanel(Page);
                };
            }
        }
    }

    private void BackButton_Click(object sender, EventArgs e) => Close();

    private void UpButton_Click(object sender, EventArgs e)
    {
        Page--;
        UpdateOrdersLayoutPanel(Page);
    }

    private void DownButton_Click(object sender, EventArgs e)
    {
        Page++;
        UpdateOrdersLayoutPanel(Page);
    }
}