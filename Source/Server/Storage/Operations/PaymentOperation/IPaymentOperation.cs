﻿using Shared.Dto.Enities;
using System;

namespace Storage.Operations.PaymentOperation;

public interface IPaymentOperation
{
    PaymentType CreatePaymentType(string name);

    PaymentType GetPaymentTypeById(Guid paymentTypeId);

    Payment AddPaymentOnOrder(Guid orderId, Guid paymentTypeId, decimal sum);

    void RemovePaymentOnOrder(Guid orderId, Guid paymentId);
}