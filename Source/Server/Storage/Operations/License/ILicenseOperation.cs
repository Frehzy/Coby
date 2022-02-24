using Storage.Entities.Interface;
using System;

namespace Storage.Operations.License;

public interface ILicenseOperation
{
    ICredentials GetCredentials(Guid userId, string password);
}