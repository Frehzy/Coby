using Shared.Dto.Enities;
using System;

namespace Storage.Operations.PaymentOperation;

public interface IPaymentOperation
{
    PaymentType CreatePaymentType(string name);

    Payment CreatePayment(Guid orderId, Guid paymentTypeId, decimal sum);
}