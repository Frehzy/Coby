using System;

namespace Shared.Dto.Enities;

public record TableDto
{
    public Guid Id { get; init; }

    public int TableNumber { get; init; }

    public TableDto() { }

    public TableDto(Guid tableId, int tableNumber)
    {
        Id = tableId;
        TableNumber = tableNumber;
    }
}