using Storage.Entities;
using Storage.Operations;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    List<ILicense> Licenses = new();

    public IOrder CreateOrder(ICredentials credentials, ITable table)
    {
        throw new NotImplementedException();
    }

    public void GetCredentials(Guid userId, string password)
    {
        throw new NotImplementedException();
    }
}