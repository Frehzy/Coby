using System;

namespace Storage.Entities.Implementation;

public class Nomenclature
{
    public Guid ParentId { get; set; }

    public Guid ChildId { get; set; }

    public decimal Amount { get; set; }

    public Nomenclature() { }

    public Nomenclature(Guid parentId, Guid childId, decimal amount)
    {
        ParentId = parentId;
        ChildId = childId;
        Amount = amount;
    }
}