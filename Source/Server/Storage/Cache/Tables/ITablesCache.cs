using Storage.Entities.Interface;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Tables;

public interface ITablesCache
{
    public IReadOnlyCollection<ITable> Tables { get; }

    public ITable TryAdd(ITable table);

    public ITable TryFind(Guid tableId);

    public void TryRemove(Guid tableId);
}