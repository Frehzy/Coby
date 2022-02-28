using Shared.Dto.Enities;
using System;

namespace Storage.Operations.PaymentOperation;

public interface IPaymentOperation
{
    PaymentType CreatePaymentType(string name);

    Payment CreatePayment(Guid orderId, Guid paymentTypeId, decimal sum);

    Payment AddPaymentOnOrder(Guid orderId, Guid paymentTypeId, decimal sum);

    void RemovePaymentOnOrder(Guid orderId, Guid paymentId);
}