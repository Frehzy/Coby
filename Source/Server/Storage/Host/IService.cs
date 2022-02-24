using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IService
{
    [OperationContract]
    ClientInstance GetClient();
}