using Shared.Dto.Enities;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetPaymentType
{
    public AllCache Cache { get; }

    public GetPaymentType(AllCache cache) =>
        Cache = cache;

    public PaymentType TryGetPaymentTypeById(Guid paymentTypeId) =>
        Helper.PaymentTypeById(Cache, paymentTypeId, out PaymentType paymentTypeOnCache) is null
            ? default
            : paymentTypeOnCache;

    public List<PaymentType> GetPaymentTypes() =>
        Cache.PaymentTypesCache.GetPaymentTypesCache();
}