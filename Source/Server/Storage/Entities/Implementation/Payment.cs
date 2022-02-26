using Storage.Entities.Interface;
using System;

namespace Storage.Entities.Implementation;

public class Payment : PaymentType, IPayment
{
    public decimal Sum { get; }

    public Payment(Guid paymentId, string name, decimal sum) : base(paymentId, name)
    {
    }
}