using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetNomenclature
{
    public AllCache Cache { get; }

    public GetNomenclature(AllCache cache) =>
        Cache = cache;
    
    public List<Nomenclature> GetNomenclaturesByChildId(Guid childId) =>
        Helper.NomenclatureByChildId(Cache, childId, out List<Nomenclature> nomenclatures) is null
            ? throw new EntityNotFound(childId)
            : nomenclatures;

    public List<Nomenclature> GetNomenclaturesByParentId(Guid parentId) =>
        Helper.NomenclatureByParentId(Cache, parentId, out List<Nomenclature> nomenclatures) is null
            ? throw new EntityNotFound(parentId)
            : nomenclatures;

    public List<Nomenclature> GetNomenclatures() =>
        Cache.NomenclatureCache.GetNomenclaturesCache();
}