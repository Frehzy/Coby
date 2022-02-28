#nullable enable

using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IPaymentTypeCache
{
    [OperationContract]
    List<PaymentType> GetPaymentTypesCache();

    [OperationContract]
    PaymentType AddPaymentType(PaymentType paymentType);

    [OperationContract]
    PaymentType? RemovePaymentType(Guid paymentTypeId);

}