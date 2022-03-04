using Storage.Cache;

namespace Storage.Operations.GetBy;

public class GetByCache
{
    public AllCache Cache { get; set; }

    public GetByCache(AllCache cache) =>
        Cache = cache;

    public GetNomenclature GetNomenclatureOperation() => new(Cache);

    public GetOrder GetOrder() => new(Cache);

    public GetProduct GetProduct() => new(Cache);

    public GetTable GetTable() => new(Cache);

    public GetWaiter GetWaiter() => new(Cache);

    public GetPaymentType GetPaymentType() => new(Cache);
}