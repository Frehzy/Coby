using Storage.Entities.Interface;
using System;

namespace Storage.Entities.Implementation;

public class PaymentType : IPaymentType
{
    public Guid Id { get; }

    public string Name { get; }

    public PaymentType(Guid paymentId, string name)
    {
        Id = paymentId;
        Name = name;
    }
}