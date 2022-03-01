using Shared.Dto.Enities;
using System;
using System.Collections.Generic;

namespace Storage.Operations.NomenclatureOperation;

public interface INomenclatureOperation
{
    Nomenclature CreateNomenclature(Guid parentId, Guid childId, decimal amount);

    List<Nomenclature> GetNomenclaturesByParentId(Guid parentId);

    List<Nomenclature> GetNomenclaturesByChildId(Guid childId);
}