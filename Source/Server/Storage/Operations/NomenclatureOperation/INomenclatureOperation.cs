using Shared.Dto.Enities;
using System;

namespace Storage.Operations.NomenclatureOperation;

public interface INomenclatureOperation
{
    Nomenclature CreateNomenclature(Guid parentId, Guid childId, decimal amount);
}