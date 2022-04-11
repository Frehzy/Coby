using Shared.Dto.Enums;
using System;

namespace Storage.DataBase;

internal class PaymentTypeDB
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string PaymentEnum { get; set; }

    public PaymentTypeDB() { }

    public PaymentTypeDB(Guid paymentId, string name, PaymentEnum paymentEnum)
    {
        Id = paymentId;
        Name = name;
        PaymentEnum = paymentEnum.ToString();
    }

    public PaymentEnum GetPaymentEnum() => (PaymentEnum)Enum.Parse(typeof(PaymentEnum), PaymentEnum);
}