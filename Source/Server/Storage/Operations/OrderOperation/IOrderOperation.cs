using Shared.Dto.Enities;
using System;
using System.Collections.Generic;

namespace Storage.Operations.OrderOperation;

public interface IOrderOperation
{
    Order CreateOrder(Credentials credentials, Table table);

    Order GetOrderById(Credentials credentials, Guid orderId);

    List<Order> GetOrders();

    bool RemoveOrder(Credentials credentials, Guid orderId);
}