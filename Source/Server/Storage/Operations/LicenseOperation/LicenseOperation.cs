using Shared.Dto.Enities;
using Storage.Cache;

namespace Storage.Operations.LicenseOperation;

public class LicenseOperation : ILicenseOperation
{
    public AllCache Cache { get; set; }

    public Credentials GetCredentials(string password, out Credentials credentials)
    {
        var waiter = Helper.WaiterByPassword(Cache, password, out _);
        return credentials = waiter is not null ? new Credentials(waiter.Id) : default;
    }
}