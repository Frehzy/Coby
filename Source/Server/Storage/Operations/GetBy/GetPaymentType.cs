using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetPaymentType
{
    public AllCache Cache { get; }

    public GetPaymentType(AllCache cache) =>
        Cache = cache;

    public PaymentType GetPaymentTypeById(Guid paymentTypeId) =>
        Helper.PaymentTypeById(Cache, paymentTypeId, out PaymentType paymentTypeOnCache) is null
            ? throw new EntityNotFound(paymentTypeId)
            : paymentTypeOnCache;

    public List<PaymentType> GetPaymentTypes() =>
        Cache.PaymentTypesCache.GetPaymentTypesCache();

    public PaymentType? TryGetPaymentTypeById(Guid paymentTypeId) =>
        Helper.PaymentTypeById(Cache, paymentTypeId, out PaymentType paymentTypeOnCache) is null
            ? default
            : paymentTypeOnCache;
}