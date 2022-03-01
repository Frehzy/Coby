using Shared.Dto.Enities;

namespace Storage.Operations.LicenseOperation;

public interface ILicenseOperation
{
    Credentials GetCredentials(string password, out Credentials credentials);
}