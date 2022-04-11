using Shared.Dto.Enities;
using Shared.Dto.Enums;
using System;

namespace Storage.DataBase.Converter;

internal static class PaymentTypeConverter
{
    public static PaymentType Converter(PaymentTypeDB paymentType) =>
        new(paymentType.Id, paymentType.Name, ConvertPaymentEnum(paymentType.PaymentEnum));

    private static PaymentEnum ConvertPaymentEnum(string paymentEnum) =>
        (PaymentEnum)Enum.Parse(typeof(PaymentEnum), paymentEnum);
}