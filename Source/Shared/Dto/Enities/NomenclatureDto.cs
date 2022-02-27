using System;

namespace Shared.Dto.Enities;

public record NomenclatureDto
{
    public Guid ParentId { get; init; }

    public Guid ChildId { get; init; }

    public decimal Amount { get; init; }

    public NomenclatureDto() { }

    public NomenclatureDto(Guid parentId, Guid childId, decimal amount)
    {
        ParentId = parentId;
        ChildId = childId;
        Amount = amount;
    }
}