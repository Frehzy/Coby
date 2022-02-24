using Storage.Entities.Interface;

namespace Storage.Operations.Order;

public interface IOrderOperation
{
    IOrder CreateOrder(ICredentials credentials, IWaiter waiter, ITable table);
}