using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations.PaymentOperation;

public class PaymentOperation : IPaymentOperation
{
    public AllCache Cache { get; set; }

    public PaymentType CreatePaymentType(string name)
    {
        if (Helper.PaymentTypeByName(Cache, name, out PaymentType paymentTypeOnCache) is not null)
            throw new EntityAlreadyExistsException(paymentTypeOnCache.Id);

        return Cache.PaymentTypesCache.AddPaymentType(new PaymentType(Guid.NewGuid(), name));
    }

    public Payment AddPaymentOnOrder(Guid orderId, Guid paymentTypeId, decimal sum)
    {
        if (Helper.PaymentById(Cache, orderId, paymentTypeId, out Order orderOnCache, out Payment paymentOnOrder) is not null)
            throw new EntityAlreadyExistsException(paymentOnOrder.Id);

        var paymentType = Helper.PaymentTypeById(Cache, paymentTypeId, out _);
        var payment = new Payment(paymentType.Id, paymentType.Name, sum);
        orderOnCache.Payment.Add(payment.Id, payment);

        return payment;
    }

    public void RemovePaymentOnOrder(Guid orderId, Guid paymentId)
    {
        if (Helper.PaymentById(Cache, orderId, paymentId, out Order orderOnCache, out Payment paymentOnOrder) is null)
            throw new EntityNotFound(paymentId);

        orderOnCache.Payment.Remove(paymentOnOrder.Id);
    }

    public PaymentType GetPaymentTypeById(Guid paymentTypeId)
    {
        if (Helper.PaymentTypeById(Cache, paymentTypeId, out PaymentType paymentTypeOnCache) is null)
            throw new EntityNotFound(paymentTypeId);

        return paymentTypeOnCache;
    }
}