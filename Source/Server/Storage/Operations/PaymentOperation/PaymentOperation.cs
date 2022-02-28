using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations.PaymentOperation;

public class PaymentOperation : IPaymentOperation
{
    public AllCache Cache { get; set; }

    public Payment CreatePayment(Guid orderId, Guid paymentTypeId, decimal sum)
    {
        if (Helper.PaymentOnOrderById(Cache, orderId, paymentTypeId, out Payment paymentOnOrder) is not null)
            throw new EntityAlreadyExistsException(paymentOnOrder.Id);

        var order = Helper.OrderById(Cache, orderId, out _);
        var paymentType = Helper.PaymentTypeById(Cache, paymentTypeId);
        var payment = new Payment(paymentType.Id, paymentType.Name, sum);
        order.Payment.Add(paymentType.Id, payment);
        return payment;
    }

    public PaymentType CreatePaymentType(string name)
    {
        if (Helper.PaymentTypeByName(Cache, name, out PaymentType paymentTypeOnCache) is not null)
            throw new EntityAlreadyExistsException(paymentTypeOnCache.Id);

        return Cache.PaymentTypesCache.AddPaymentType(new PaymentType(Guid.NewGuid(), name));
    }
}