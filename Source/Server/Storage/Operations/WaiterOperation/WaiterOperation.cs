using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations.WaiterOperation;

public class WaiterOperation : IWaiterOperation
{
    public AllCache Cache { get; set; }

    public Waiter CreateWaiter(string name, string password)
    {
        if (Cache is null)
            throw new ArgumentNullException("Cache cannot be null.");

        var waiterOnCache = Cache.WaitersCache.GetWaitersCache().FirstOrDefault(x => x.Password.Equals(password));
        if (waiterOnCache is not null)
            throw new EntityAlreadyExistsException(waiterOnCache.Id);

        return Cache.WaitersCache.AddWaiter(new Waiter(Guid.NewGuid(), name, password, WaiterSessionStatus.Closed));

    }
}