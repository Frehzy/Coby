using System;

namespace Storage.Entities.Implementation;

public class Table
{
    public Guid Id { get; set; }

    public int TableNumber { get; set; }

    public Table() { }

    public Table(Guid tableId, int tableNumber)
    {
        Id = tableId;
        TableNumber = tableNumber;
    }
}