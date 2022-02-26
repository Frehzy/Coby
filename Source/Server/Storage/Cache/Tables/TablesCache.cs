using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache.Tables;

public class TablesCache : ITablesCache
{
    private readonly ConcurrentDictionary<Guid, ITable> _tables = new();

    public IReadOnlyCollection<ITable> Tables => _tables.Values.ToList();

    public ITable TryAdd(ITable table) =>
        _tables.TryAdd(table.Id, table)
        ? table
        : throw new OverflowException($"An element with the same Guid [{table.Id}] already exists.");

    public ITable TryFind(Guid tableId) =>
        _tables.TryGetValue(tableId, out var table)
            ? table : default;

    public void TryRemove(Guid tableId)
    {
        if (_tables.TryRemove(tableId, out _) is false)
            throw new EntityNotFound(tableId);
    }
}