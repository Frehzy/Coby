using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetTable
{
    public AllCache Cache { get; }

    public GetTable(AllCache cache) =>
        Cache = cache;

    public Table GetTableById(Guid tableId) =>
        Helper.TableById(Cache, tableId, out Table tableOnCache) is null
            ? throw new EntityNotFound(tableId)
            : tableOnCache;

    public List<Table> GetTables() =>
        Cache.TablesCache.GetTablesCache();
}