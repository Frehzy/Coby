using Storage.DataBase;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IWaiterFaceCache
{
    [OperationContract]
    List<WaiterFace> GetWaiterFacesCache();

    [OperationContract]
    WaiterFace AddOrUpdateWaiterFace(WaiterFace waiterFace);

    [OperationContract]
    List<WaiterFace> RemoveWaiterFace(Guid waiterFaceId);
}