﻿using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Operations.PaymentOperation;

public class PaymentOperations
{
    AllCache Cache { get; }

    Order Order { get; }

    List<PaymentType> PaymentTypes { get; }

    public PaymentOperations(AllCache cache, Order order, List<PaymentType> paymentTypes)
    {
        Cache = cache;
        Order = order;
        PaymentTypes = paymentTypes;
    }

    public Payment AddPaymentOnOrder(Credentials credentials, Guid paymentTypeId, decimal sum)
    {
        if (Helper.CheckLicense(Cache, credentials, out var license) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Order.Payment.TryGetValue(paymentTypeId, out _) is true)
            throw new EntityAlreadyExistsException(paymentTypeId);

        var paymentType = PaymentTypes.FirstOrDefault(x => x.Id.Equals(paymentTypeId));
        if (paymentType is null)
            throw new EntityNotFound(paymentTypeId);

        var paymentSum = Order.GetPayments().Sum(x => x.Sum);
        if (paymentSum + sum > Order.Sum)
            sum = (decimal)Order.Sum - paymentSum;

        if (sum <= 0)
            throw new ArgumentException("Сумма не может быть меньше или равна 0.");

        var payment = new Payment(paymentType.Id, paymentType.Name, sum);
        Order.Payment.Add(payment.Id, payment);
        HistoryHelper.OrderHistory(Order, payment.Id, Entities.Payment, ActionsEnum.Added);
        return payment;
    }

    public void RemovePaymentOnOrder(Credentials credentials, Guid paymentId)
    {
        if (Helper.CheckLicense(Cache, credentials, out var license) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Order.Payment.TryGetValue(paymentId, out var payment) is false)
            throw new EntityNotFound(paymentId);

        Cache.DangerousOperationCache.AddDangerousOperations(new(license.Id, $"Remove payment [{paymentId}] on order [{Order.Id}]"));
        Order.Payment.Remove(payment.Id);
        HistoryHelper.OrderHistory(Order, paymentId, Entities.Payment, ActionsEnum.Remove);
    }
}