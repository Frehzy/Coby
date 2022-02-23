using System;

namespace Storage.Entities.EntityCreater;

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