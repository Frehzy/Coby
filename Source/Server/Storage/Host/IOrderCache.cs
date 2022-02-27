using Shared.Dto.Enities;
using Storage.Entities.Implementation;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IOrderCache
{
    [OperationContract]
    List<Order> GetOrdersCache();

    [OperationContract]
    OrderDto AddOrder(Order order);

    [OperationContract]
    bool RemoveOrder(Guid orderId);

}