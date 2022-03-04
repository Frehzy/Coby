using Shared.Dto.Enities;
using System;
using System.Collections.Generic;

namespace Storage.Operations.OrderOperation;

public interface IOrderOperation
{
    Order CreateOrder(Credentials credentials, Table table);

    bool RemoveOrder(Credentials credentials, Guid orderId);

    List<Order> GetOrders();

    Order SaveOrder(Order order);
}