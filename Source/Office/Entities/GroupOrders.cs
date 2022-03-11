using Office.Enums;
using Shared.Dto.Enities;
using System.Collections.Generic;

namespace Office.Entities;

public class GroupOrders
{
    public string AxisXLabel { get; set; }

    public string TitleLabel { get; set; }

    public List<Order> Orders { get; set; }

    public GroupTypeEnum GroupType { get; set; }

    public GroupOrders() { }

    public GroupOrders(string axisXLabel, string titleLabel, List<Order> orders, GroupTypeEnum groupType)
    {
        AxisXLabel = axisXLabel;
        TitleLabel = titleLabel;
        Orders = orders;
        GroupType = groupType;
    }
}