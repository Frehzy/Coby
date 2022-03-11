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
    private Func<List<Order>> _getOpenOrders => _client.GetByCacheOperation.GetOrder().GetOrders;
    private Func<List<Order>> _getCloseOrders => _client.GetCloseOrders.Invoke;
    private List<Order> _orders => _getOpenOrders.Invoke().Concat(_getCloseOrders.Invoke()).ToList();
    private readonly IClient _client;

    public ReportsForm(IClient client)
    {
        InitializeComponent();
        _client = client;
        _ = FormHelper.CreateMaterialSkinManager(this);
    }
}