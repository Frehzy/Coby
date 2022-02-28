#nullable enable

using Shared.Dto.Enities;
using Storage.Entities.Implementation;
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
    PaymentTypeDto AddPaymentType(PaymentType paymentType);

    [OperationContract]
    PaymentTypeDto? RemovePaymentType(Guid paymentTypeId);

}