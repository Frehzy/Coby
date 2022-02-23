using Storage.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

internal interface IServerCallback
{
    [OperationContract(IsOneWay = true)]
    void OrdersCallback(IReadOnlyList<IOrder> order);
}