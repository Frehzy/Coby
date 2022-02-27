using System;

namespace Storage.Entities.Implementation;

public class PaymentType
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public PaymentType() { }

    public PaymentType(Guid paymentId, string name)
    {
        Id = paymentId;
        Name = name;
    }
}