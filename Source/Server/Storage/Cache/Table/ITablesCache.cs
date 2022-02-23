#nullable enable

using Storage.Entities;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Table;

public interface ITablesCache
{
    IReadOnlyList<ITable> Tables { get; }

    ITable TryAdd(ITable table);

    void TryRemove(Guid tableId);

    ITable? TryFind(Guid tableId);
}