using Storage.Entities.Interface;
using System;
using System.ServiceModel;

namespace Storage.Operations;

public interface ILicenseOperation
{
    [OperationContract]
    ICredentials GetCredentials(Guid userId, string password);
}