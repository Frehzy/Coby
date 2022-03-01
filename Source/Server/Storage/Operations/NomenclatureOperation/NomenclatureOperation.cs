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
        if (Helper.NomenclatureByParentAndChildId(Cache, parentId, childId, out Nomenclature nomenclatureOnCache) is not null)
            throw new EntityAlreadyExistsException(new List<Guid>() { nomenclatureOnCache.ParentId, nomenclatureOnCache.ChildId });

        var nomenclature = new Nomenclature(parentId, childId, amount);
        Cache.NomenclatureCache.AddNomenclature(nomenclature);
        return nomenclature;
    }

    public List<Nomenclature> GetNomenclaturesByChildId(Guid childId) =>
        Helper.NomenclatureByChildId(Cache, childId, out List<Nomenclature> nomenclatures) is null
            ? throw new EntityNotFound(childId)
            : nomenclatures;

    public List<Nomenclature> GetNomenclaturesByParentId(Guid parentId) =>
        Helper.NomenclatureByParentId(Cache, parentId, out List<Nomenclature> nomenclatures) is null
            ? throw new EntityNotFound(parentId)
            : nomenclatures;
}