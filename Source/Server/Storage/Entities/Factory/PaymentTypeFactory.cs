using Shared.Dto.Enities;
using Storage.Entities.Implementation;

namespace Storage.Entities.Factory;

internal static class PaymentTypeFactory
{
    public static PaymentTypeDto CreateDto(PaymentType paymentType) =>
        new()
        {
            Id = paymentType.Id,
            Name = paymentType.Name
        };

    public static PaymentType Create(PaymentTypeDto paymentTypeDto) =>
        new(paymentTypeDto.Id, paymentTypeDto.Name);
}