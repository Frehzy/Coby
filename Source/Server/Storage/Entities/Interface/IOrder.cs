using Storage.Enums;
using System;
using System.Collections.Generic;

namespace Storage.Entities.Interface;

public interface IOrder
{
    Guid Id { get; }

    ITable Table { get; }

    IWaiter Waiter { get; }

    decimal Sum { get; }

    IReadOnlyCollection<IPayment> Payment { get; }

    IReadOnlyCollection<IGuest> Guests { get; }

    OrderStatus OrderStatus { get; }

    DateTime StartTime { get; }

    DateTime? EndTime { get; }

    void ChangeSum(decimal sum);

    IGuest TryAddGuest(IGuest guest);

    void RemoveGuestById(Guid guestId);

    IPayment TryAddPayment(IPayment payment);

    void RemovePayment(Guid paymentId);
}