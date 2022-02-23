using Storage.Entities;
using System.ServiceModel;

namespace Storage.Host;

internal interface IServerCallback
{
    [OperationContract(IsOneWay = true)]
    void OrdersCallback(IOrder order);
}