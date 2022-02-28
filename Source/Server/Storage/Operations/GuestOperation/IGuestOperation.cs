using Shared.Dto.Enities;
using System;

namespace Storage.Operations.GuestOperation;

internal interface IGuestOperation
{
    Guest AddGuestOnOrder(Guid orderId);

    void RemoveGuestOnOrder(Guid orderId, Guid guestId);
}