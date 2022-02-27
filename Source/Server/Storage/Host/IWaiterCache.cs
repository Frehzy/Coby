using Shared.Dto.Enities;
using Storage.Entities.Implementation;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IWaiterCache
{
    [OperationContract]
    List<Waiter> GetWaitersCache();

    [OperationContract]
    WaiterDto AddWaiter(Waiter waiter);

    [OperationContract]
    bool RemoveWaiter(Guid waiterId);

}