using Shared.Dto.Enities;
using Storage.Entities.Implementation;
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
    List<NomenclatureDto> RemoveNomenclature(Guid parentId, Guid childId);
}