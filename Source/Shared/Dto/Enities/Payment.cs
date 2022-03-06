using System;

namespace Shared.Dto.Enities;

public class Payment : PaymentType
{
    public decimal Sum { get; set; }

    public Payment() { }

    public Payment(Guid paymentId, string name, decimal sum) : base(paymentId, name)
    {
        Sum = sum;
    }
}