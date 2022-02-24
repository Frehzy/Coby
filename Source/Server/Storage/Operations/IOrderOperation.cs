using Storage.Entities.Implementation;
using Storage.Entities.Interface;
using System.ServiceModel;

namespace Storage.Operations;

public interface IOrderOperation
{
    [OperationContract]
    IOrder CreateOrder(Credentials credentials, Waiter waiter, Table table);
}