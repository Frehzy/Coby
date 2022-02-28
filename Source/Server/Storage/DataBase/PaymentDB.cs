using System;

namespace Storage.DataBase;

internal class PaymentDB
{
    public Guid OrderId { get; set; }

    public Guid PaymentId { get; set; }

    public decimal Sum { get; set; }

    public PaymentDB() { }

    public PaymentDB(Guid orderId, Guid paymentId, decimal sum)
    {
        OrderId = orderId;
        PaymentId = paymentId;
        Sum = sum;
    }
}