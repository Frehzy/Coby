using Office.Entities;
using Office.Enums;
using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Office.Helper;

internal static class GroupByHelper
{
    private static readonly List<string> _month = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();

    public static IEnumerable<GroupOrders> GroupOrderByDay(IEnumerable<Order> orders, int monthIndex) =>
        orders.Where(x => x.StartTime.Month.Equals(monthIndex + 1))
               .GroupBy(x => x.StartTime.Day)
               .OrderBy(x => x.Key)
               .Select(x => new GroupOrders(x.Key.ToString(), _month[monthIndex], x.Select(x => x).ToList(), GroupTypeEnum.Day));

    public static IEnumerable<GroupOrders> GroupOrderByMonth(IEnumerable<Order> orders, int year) =>
        orders.Where(x => x.StartTime.Year.Equals(year))
               .GroupBy(x => x.StartTime.Month)
               .OrderBy(x => x.Key)
               .Select(x => new GroupOrders(_month[x.Key - 1], year.ToString(), x.Select(x => x).ToList(), GroupTypeEnum.Month));

    public static IEnumerable<GroupProduct> GroupNomenclatureById(Func<Guid, List<Nomenclature>> getNomenclatureByParentId,
                                                                  Func<Guid, Product> getProductById,
                                                                  IEnumerable<Guid> productIds) =>
        productIds.SelectMany(productId => getNomenclatureByParentId(productId))
                .GroupBy(x => x.ChildId)
                .Select(x => new { ProductId = x.GroupBy(x => x.ChildId).Select(x => x.Key).First(), Count = x.Count(), Sum = x.Sum(x => x.Amount) })
                .Select(x => new GroupProduct(getProductById(x.ProductId), x.Sum, x.Count))
                .ToList();
}