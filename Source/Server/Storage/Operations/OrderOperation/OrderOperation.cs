using Shared.Dto.Exceptions;
using Storage.Cache;
using Storage.Entities.Implementation;
using System;

namespace Storage.Operations.OrderOperation;

public class OrderOperation : IOrderOperation
{
    public AllCache Cache { get; set; }

    public Order CreateOrder(Credentials credentials, Waiter waiter, Table table, AllCache cache)
    {
        if (cache.TryGetValue(cache.LicensesCache.GetLicensesCache(), credentials.WaiterId) is null)
            throw new EntityNotFound(credentials.WaiterId);

        return new Order(Guid.NewGuid(), table, waiter);
    }
}