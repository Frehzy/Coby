using Storage.Cache;
using Storage.Operations;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IService
{
    [OperationContract]
    AllCache GetCache();

    [OperationContract]
    AllOperations GetOperations();
}