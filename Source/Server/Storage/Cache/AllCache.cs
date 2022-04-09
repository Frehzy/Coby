#nullable enable

using Storage.Host;

namespace Storage.Cache;

public class AllCache
{
    public ILicenseCache LicensesCache { get; }

    public IOrderCache OrdersCache { get; }

    public IPaymentTypeCache PaymentTypesCache { get; }

    public IProductCache ProductsCache { get; }

    public ITableCache TablesCache { get; }

    public IWaiterCache WaitersCache { get; }

    public INomenclatureCache NomenclatureCache { get; }

    public IWaiterFaceCache WaiterFaceCache { get; }

    public IDangerousOperation DangerousOperationCache { get; }

    public AllCache() { }

    public AllCache(IService service)
    {
        LicensesCache = service;
        OrdersCache = service;
        PaymentTypesCache = service;
        ProductsCache = service;
        TablesCache = service;
        WaitersCache = service;
        NomenclatureCache = service;
        WaiterFaceCache = service;
        DangerousOperationCache = service;
    }
}