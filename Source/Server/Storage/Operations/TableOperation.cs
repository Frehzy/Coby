using Shared.Dto.Enities;
using Storage.Cache;
using System.Collections.Generic;

namespace Storage.Operations;

public class TableOperation
{
    public AllCache Cache { get; set; }

    public List<Table> GetTables() =>
        Cache.TablesCache.GetTablesCache();
}