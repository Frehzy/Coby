using Shared.Dto.Enities;

namespace Storage.Operations.WaiterOperation;

public interface IWaiterOperation
{
    Waiter CreateWaiter(string name, string password);
}