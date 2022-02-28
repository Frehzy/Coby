using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;

namespace Storage.Operations.TableOperation;

public class TableOperation : ITableOperation
{
    public AllCache Cache { get; set; }

    public Table CreateTable(int tableNumber)
    {
        if (Helper.TableByNumber(Cache, tableNumber, out Table tableOnCache) is not null)
            throw new EntityAlreadyExistsException(tableOnCache.Id);

        return Cache.TablesCache.AddTable(new Table(Guid.NewGuid(), tableNumber));
    }
}