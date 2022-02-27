using Shared.Dto.Enities;
using Storage.Entities.Implementation;

namespace Storage.Entities.Factory;

internal static class PaymentFactory
{
    public static PaymentDto CreateDto(Payment payment) =>
        new()
        {
            Id = payment.Id,
            Name = payment.Name,
            Sum = payment.Sum
        };

    public static Payment Create(PaymentDto paymentDto) =>
        new(paymentDto.Id,
            paymentDto.Name,
            paymentDto.Sum);
}