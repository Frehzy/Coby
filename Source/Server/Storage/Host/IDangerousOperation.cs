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
    DangerousOperationsDto AddDangerousOperations(DangerousOperationsDto dangerousOperations);

    [OperationContract]
    DangerousOperationsDto RemoveDangerousOperations(Guid dangerousOperationsId);
}