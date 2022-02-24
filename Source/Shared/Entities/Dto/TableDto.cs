using System;

namespace Shared.Dto;

public class TableDto
{
    public Guid Id { get; }

    public int TableNumber { get; }

    public TableDto(Guid tableId, int tableNumber)
    {
        Id = tableId;
        TableNumber = tableNumber;
    }
}