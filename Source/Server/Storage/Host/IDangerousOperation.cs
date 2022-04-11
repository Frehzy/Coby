using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IDangerousOperation
{
    [OperationContract]
    List<DangerousOperationsDto> GetDangerousOperationsCache();

    [OperationContract]
    bool AddDangerousOperations(DangerousOperationsDto dangerousOperations);

    [OperationContract]
    bool RemoveDangerousOperations(Guid dangerousOperationsId);
}