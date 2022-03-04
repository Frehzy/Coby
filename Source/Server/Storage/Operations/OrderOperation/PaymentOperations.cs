using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Operations.PaymentOperation;

public class PaymentOperations
{
    Order Order { get; }

    List<PaymentType> PaymentTypes { get; }

    public PaymentOperations(Order order, List<PaymentType> paymentTypes)
    {
        Order = order;
        PaymentTypes = paymentTypes;
    }

    public Payment AddPaymentOnOrder(Guid paymentTypeId, decimal sum)
    {
        if (Order.Payment.TryGetValue(paymentTypeId, out _) is true)
            throw new EntityAlreadyExistsException(paymentTypeId);

        var paymentType = PaymentTypes.FirstOrDefault(x => x.Equals(paymentTypeId));
        if (paymentType is null)
            throw new EntityNotFound(paymentTypeId);

        var payment = new Payment(paymentType.Id, paymentType.Name, sum);
        Order.Payment.Add(payment.Id, payment);
        return payment;
    }

    public void RemovePaymentOnOrder(Guid paymentId)
    {
        if (Order.Payment.TryGetValue(paymentId, out var payment) is true)
            throw new EntityNotFound(paymentId);

        Order.Payment.Remove(payment.Id);
    }
}