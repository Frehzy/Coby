using Shared.Dto.Enums;
using System;

namespace Shared.Dto.Enities;

public class PaymentType
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public PaymentEnum PaymentEnum { get; set; }

    public PaymentType() { }

    public PaymentType(Guid paymentId, string name, PaymentEnum paymentEnum)
    {
        Id = paymentId;
        Name = name;
        PaymentEnum = paymentEnum;
    }
}