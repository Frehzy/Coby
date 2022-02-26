using Storage.Entities.Interface;
using System;
using System.Collections.Generic;

namespace Storage.Cache.PaymentTypes;

public interface IPaymentTypeCache
{
    public IReadOnlyCollection<IPaymentType> PaymentTypes { get; }

    public IPaymentType TryAdd(IPaymentType paymentType);

    public IPaymentType TryFind(Guid paymentTypeId);

    public void TryRemove(Guid paymentTypeId);
}