using Shared.Dto;
using Shared.Exceptions;
using Storage.Entities.ConverterToDto;
using Storage.Entities.Implementation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache;

public class TablesCache
{
    private readonly ConcurrentDictionary<Guid, Table> _tables = new();

    public IReadOnlyList<TableDto> Tables => _tables.Values.Select(x => new ToTableDto(x).Convert()).ToList();

    public Table TryAdd(Table table) =>
        _tables.TryAdd(table.Id, table)
        ? table
        : throw new OverflowException($"An element with the same Guid [{table.Id}] already exists.");

    public Table TryFind(Guid tableId) =>
        _tables.TryGetValue(tableId, out var license)
            ? license : default;

    public void TryRemove(Guid tableId)
    {
        if (_tables.TryRemove(tableId, out _) is false)
            throw new EntityNotFound(tableId);
    }
}