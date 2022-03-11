using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Forms;

public partial class ReportsForm : MaterialForm
{
    private List<Order> _getOpenOrders => _client.GetByCacheOperation.Order.GetOrders();
    private List<Order> _getCloseOrders => _client.GetCloseOrders();
    private IEnumerable<Order> _orders => _getOpenOrders.Concat(_getCloseOrders);
    private readonly IClient _client;

    public ReportsForm(IClient client)
    {
        InitializeComponent();
        _client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }

    private void UpdateRevisionButton_Click(object sender, EventArgs e)
    {
        var orders = GetOrdersByDate(_getCloseOrders, StartDateTimePicker.Value, EndDateTimePicker.Value).ToList();
        var productsId = orders.SelectMany(x => x.GetGuests()).SelectMany(x => x.GetProducts()).Select(x => x.Id).ToList();

        var groupProducts = GroupByHelper.GroupNomenclatureById(_client.GetByCacheOperation.GetNomenclatureOperation.GetNomenclaturesByParentId,
                                                                _client.GetByCacheOperation.Product.GetProductById,
                                                                productsId);
        DataGridHelper.FillTable(RevisionDgv, groupProducts.Select(x =>
        {
            return new { ProductId = x.Product.Id, Name = x.Product.ProductName, x.Product.Price, Remainder = x.Sum, x.Count };
        }).ToList());
    }

    private IEnumerable<Order> GetOrdersByDate(IEnumerable<Order> orders, DateTime startDate, DateTime endDate) =>
        orders.Where(x => x.StartTime.Date >= startDate.Date && x.StartTime.Date <= endDate.Date);
}