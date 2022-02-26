using Storage.Entities.Interface;
using System;

namespace Storage.DataBase.ConvertType;

internal class PaymentType : IPaymentType
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public PaymentType() { }
}