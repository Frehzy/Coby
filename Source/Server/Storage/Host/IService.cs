using Storage.Entities;
using System;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract(CallbackContract = typeof(IServerCallback))]
public interface IService
{
    [OperationContract]
    void GetCredentials(Guid userId, string password);

    [OperationContract]
    IOrder CreateOrder(ICredentials credentials, ITable table);
}