using System;

namespace Shared.Dto.Enities;

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