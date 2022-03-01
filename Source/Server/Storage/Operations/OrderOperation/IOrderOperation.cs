using Shared.Dto.Enities;
using System;

namespace Storage.Operations.OrderOperation;

public interface IOrderOperation
{
    Order CreateOrder(Credentials credentials, Waiter waiter, Table table);

    Order GetOrderById(Credentials credentials, Guid orderId);

    bool RemoveOrder(Credentials credentials, Guid orderId);
}