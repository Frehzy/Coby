using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.NomenclatureOperation;

public class NomenclatureOperation : INomenclatureOperation
{
    public AllCache Cache { get; set; }

    public Nomenclature CreateNomenclature(Guid parentId, Guid childId, decimal amount)
    {
        var childProductOnCache = Helper.NomenclatureByParentAndChildId(Cache, parentId, childId);
        if (childProductOnCache is not null)
            throw new EntityAlreadyExistsException(new List<Guid>() { parentId, childId });

        var nomenclature = new Nomenclature(parentId, childId, amount);
        Cache.NomenclatureCache.AddNomenclature(nomenclature);
        return nomenclature;
    }
}