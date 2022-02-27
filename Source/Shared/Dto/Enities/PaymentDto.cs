using System;

namespace Shared.Dto.Enities;

public record PaymentDto : PaymentTypeDto
{
    public decimal Sum { get; init; }

    public PaymentDto() { }

    public PaymentDto(Guid paymentId, string name, decimal sum) : base(paymentId, name)
    {
        Sum = sum;
    }
}