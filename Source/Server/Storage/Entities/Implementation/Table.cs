using Storage.Entities.Interface;
using System;

namespace Storage.Entities.Implementation;

public class Table : ITable
{
    public Guid Id { get; }

    public int TableNumber { get; }

    public Table(Guid tableId, int tableNumber)
    {
        Id = tableId;
        TableNumber = tableNumber;
    }
}