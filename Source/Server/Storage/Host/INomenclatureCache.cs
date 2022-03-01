using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface INomenclatureCache
{
    [OperationContract]
    List<Nomenclature> GetNomenclaturesCache();

    [OperationContract]
    void AddNomenclature(Nomenclature nomenclature);

    [OperationContract]
    List<Nomenclature> RemoveNomenclatureByParentAndChildId(Guid parentId, Guid childId);

    [OperationContract]
    List<Nomenclature> RemoveNomenclatureByChildId(Guid childId);
}