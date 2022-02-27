using Storage.Entities.Implementation;

namespace Storage.Operations.LicenseOperation;

public interface ILicenseOperation
{
    Credentials GetCredentials(string password);
}