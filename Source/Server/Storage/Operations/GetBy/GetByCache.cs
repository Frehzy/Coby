using Storage.Cache;

namespace Storage.Operations.GetBy;

public class GetByCache
{
    public AllCache Cache { get; set; }

    public GetByCache(AllCache cache) =>
        Cache = cache;

    public GetNomenclature GetNomenclatureOperation => new(Cache);

    public GetOrder Order => new(Cache);

    public GetProduct Product => new(Cache);

    public GetTable Table => new(Cache);

    public GetWaiter Waiter => new(Cache);

    public GetPaymentType PaymentType => new(Cache);

    public GetWaiterFace WaiterFace => new(Cache);
}