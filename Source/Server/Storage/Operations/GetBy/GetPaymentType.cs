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

    public PaymentType GetPaymentTypeById(Guid paymentTypeId)
    {
        if (Helper.PaymentTypeById(Cache, paymentTypeId, out PaymentType paymentTypeOnCache) is null)
            throw new EntityNotFound(paymentTypeId);

        return paymentTypeOnCache;
    }

    public List<PaymentType> GetPaymentTypes() =>
        Cache.PaymentTypesCache.GetPaymentTypesCache();
}