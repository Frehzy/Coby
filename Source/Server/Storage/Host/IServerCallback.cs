using Shared.Entities.Dto;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

public interface IServerCallback
{
    [OperationContract(IsOneWay = true)]
    void OrdersCallback(List<OrderDto> orders);
}