#nullable enable

using Shared.Dto.Enities;
using Shared.Dto.Enums;
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
    Waiter AddWaiter(Waiter waiter);

    [OperationContract]
    Waiter? RemoveWaiter(Guid waiterId);

    [OperationContract]
    Waiter ChangeWaiterStatus(Guid waiterId, WaiterSessionStatus status);
}