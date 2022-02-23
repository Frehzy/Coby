using Storage.Entities;
using System.ServiceModel;

namespace Storage.Operations;

public interface IOrderOperation
{
    [OperationContract]
    IOrder CreateOrder(ICredentials credentials, IWaiter waiter, ITable table);
}