using MaterialSkin.Controls;
using Office.ClientOperation;
using Office.Entities;
using Office.Helper;
using Office.Helper.Excel;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

    private void ReportsForm_Load(object sender, EventArgs e)
    {
        var waiters = _client.GetByCacheOperation.Waiter.GetWaiters();
        WaitersComboBox.DataSource = waiters;
        WaitersComboBox.DisplayMember = nameof(Waiter.Name);
    }

    private void UpdateRevisionButton_Click(object sender, EventArgs e) =>
        DataGridHelper.FillTable(RevisionDgv, GetRevisionProducts(StartDateTimePicker.Value, EndDateTimePicker.Value).Select(x =>
        {
            return new { ProductId = x.Product.Id, Name = x.Product.ProductName, x.Product.Price, Remainder = x.Sum, x.Count };
        }).ToList());

    private void UpdateDangerousOperationsButton_Click(object sender, EventArgs e)
    {
        var dangerousOperations = GetDangerousOperationsByDate(_client.GetByCacheOperation.DangerousOperation.GetDangerousOperations(),
                                                               StartDateTimePicker.Value,
                                                               EndDateTimePicker.Value);
        var selectedWaiter = WaitersComboBox.SelectedItem as Waiter;
        if (selectedWaiter is not null)
            dangerousOperations = dangerousOperations.Where(x => x.WaiterId.Equals(selectedWaiter.Id));

        DataGridHelper.FillTable(DangerousDgv, dangerousOperations.Select(x =>
        {
            return new { Waiter = _client.GetByCacheOperation.Waiter.GetWaiterById(x.WaiterId).Name, x.Message, x.Created };
        }).ToList());

        static IEnumerable<DangerousOperationsDto> GetDangerousOperationsByDate(IEnumerable<DangerousOperationsDto> dangerousOperationsDto, DateTime startDate, DateTime endDate) =>
            dangerousOperationsDto.Where(x => x.Created >= startDate.Date && x.Created <= endDate.Date.AddDays(1));
    }

    private void WaiterComboBoxClearButton_Click(object sender, EventArgs e) =>
        WaitersComboBox.SelectedItem = default;

    private void RevisionExcelButton_Click(object sender, EventArgs e)
    {
        var dgv = new DataGridView() { Name = nameof(Nomenclature) };
        DataGridHelper.FillTable(dgv, GetRevisionProducts(StartDateTimePicker.Value, EndDateTimePicker.Value).Select(x =>
        {
            return new { ProductId = x.Product.Id, Name = x.Product.ProductName, x.Product.Price, Remainder = x.Sum, x.Count };
        }).ToList());
        ExcelHelper.DataTableToExcel(dgv);
    }

    private IEnumerable<GroupProduct> GetRevisionProducts(DateTime startDate, DateTime endDate)
    {
        var orders = GetOrdersByDate(_getCloseOrders, startDate, endDate);
        var productsId = orders.SelectMany(x => x.GetGuests()).SelectMany(x => x.GetProducts()).Select(x => x.Id);
        return GroupByHelper.GroupNomenclatureById(_client.GetByCacheOperation.GetNomenclatureOperation.GetNomenclaturesByParentId,
                                                   _client.GetByCacheOperation.Product.GetProductById,
                                                   productsId);

        static IEnumerable<Order> GetOrdersByDate(IEnumerable<Order> orders, DateTime startDate, DateTime endDate) =>
            orders.Where(x => x.StartTime.Date >= startDate.Date && x.StartTime.Date <= endDate.Date.AddDays(1));
    }
}