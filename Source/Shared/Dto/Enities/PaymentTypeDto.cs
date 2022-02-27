using System;

namespace Shared.Dto.Enities;

public record PaymentTypeDto
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public PaymentTypeDto() { }

    public PaymentTypeDto(Guid paymentId, string name)
    {
        Id = paymentId;
        Name = name;
    }
}