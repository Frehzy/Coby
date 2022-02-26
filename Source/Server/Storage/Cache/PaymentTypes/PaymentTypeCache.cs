using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache.PaymentTypes;

public class PaymentTypeCache : IPaymentTypeCache
{
    private readonly ConcurrentDictionary<Guid, IPaymentType> _paymentTypes = new();

    public IReadOnlyCollection<IPaymentType> PaymentTypes => _paymentTypes.Values.ToList();

    public IPaymentType TryAdd(IPaymentType paymentType) =>
        _paymentTypes.TryAdd(paymentType.Id, paymentType)
            ? paymentType
            : throw new OverflowException($"An element with the same Guid [{paymentType.Id}] already exists.");

    public IPaymentType TryFind(Guid paymentTypeId) =>
        _paymentTypes.TryGetValue(paymentTypeId, out var paymentType)
            ? paymentType : default;

    public void TryRemove(Guid paymentTypeId)
    {
        if (_paymentTypes.TryRemove(paymentTypeId, out _) is false)
            throw new EntityNotFound(paymentTypeId);
    }
}