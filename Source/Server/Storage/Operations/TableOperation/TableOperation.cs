using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations.TableOperation;

public class TableOperation : ITableOperation
{
    public AllCache Cache { get; set; }

    public Table CreateTable(int tableNumber)
    {
        if (Cache is null)
            throw new ArgumentNullException("Cache cannot be null.");

        var tableOnCache = Cache.TablesCache.GetTablesCache().FirstOrDefault(x => x.TableNumber.Equals(tableNumber));
        if (tableOnCache is not null)
            throw new EntityAlreadyExistsException(tableOnCache.Id);

        return Cache.TablesCache.AddTable(new Table(Guid.NewGuid(), tableNumber));
    }
}