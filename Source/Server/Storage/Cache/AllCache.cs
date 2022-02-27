#nullable enable

using Storage.Host;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache;

public class AllCache
{
    public ILicenseCache LicensesCache { get; }

    public IOrderCache OrdersCache { get; }

    public IPaymentTypeCache PaymentTypesCache { get; }

    public IProductCache ProductsCache { get; }

    public ITableCache TablesCache { get; }

    public IWaiterCache WaitersCache { get; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public AllCache() { }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

    public AllCache(IService service)
    {
        LicensesCache = service;
        OrdersCache = service;
        PaymentTypesCache = service;
        ProductsCache = service;
        TablesCache = service;
        WaitersCache = service;
    }

    public T? TryGetValue<T>(IReadOnlyCollection<T> dictionary, Guid id) =>
        dictionary.FirstOrDefault(x => x.Equals(id));
}