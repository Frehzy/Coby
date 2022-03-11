using MaterialSkin.Controls;
using Office.Entities;
using Office.Helper;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Office.Forms.MessageForm;

public partial class GroupByForm : MaterialForm
{
    private GroupTypeEnum _selectedGroupType;
    private readonly List<string> _month;
    private readonly List<string> _year;
    private readonly List<Order> _orders;

    public GroupByForm(List<Order> orders)
    {
        InitializeComponent();
        _orders = orders;
        _month = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
        _year = Enumerable.Range(2020, DateTime.Now.Year - 2020 + 1).Select(x => x.ToString()).ToList();
        _ = FormHelper.CreateMaterialSkinManager(this);
        GroupByComboBox.DataSource = Enum.GetValues(typeof(GroupTypeEnum));
    }

    public IEnumerable<GroupOrders> GetGroupOrders()
    {
        if (ShowDialog() is not DialogResult.OK)
            return default;

        return _selectedGroupType is GroupTypeEnum.Day
            ? GroupOrderByDay(DateComboBox.SelectedIndex)
            : GroupOrderByMonth(int.Parse(DateComboBox.SelectedItem.ToString()));
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (DateComboBox.SelectedItem is null)
            return;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void GroupByComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        DateComboBox.Items.Clear();
        _selectedGroupType = GroupByComboBox.SelectedItem.ToString().Equals(nameof(GroupTypeEnum.Day))
            ? GroupTypeEnum.Day
            : GroupTypeEnum.Month;

        var addRangeItems = _selectedGroupType is GroupTypeEnum.Day
            ? _month.ToArray()
            : _year.ToArray();

        DateComboBox.Items.AddRange(addRangeItems);
    }

    private IEnumerable<GroupOrders> GroupOrderByDay(int monthIndex) =>
        _orders.Where(x => x.StartTime.Month.Equals(monthIndex + 1))
               .GroupBy(x => x.StartTime.Day)
               .OrderBy(x => x.Key)
               .Select(x => new GroupOrders(x.Key.ToString(), _month[monthIndex], x.Select(x => x).ToList(), GroupTypeEnum.Day));

    private IEnumerable<GroupOrders> GroupOrderByMonth(int year) =>
        _orders.Where(x => x.StartTime.Year.Equals(year))
               .GroupBy(x => x.StartTime.Month)
               .OrderBy(x => x.Key)
               .Select(x => new GroupOrders(_month[x.Key - 1], year.ToString(), x.Select(x => x).ToList(), GroupTypeEnum.Month));
}