using Shared.Dto.Enities;
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
    Order AddOrder(Order order);

    [OperationContract]
    bool RemoveOrder(Guid orderId);

}