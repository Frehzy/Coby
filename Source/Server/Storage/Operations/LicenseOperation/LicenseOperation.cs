using Shared.Dto.Enities;
using Storage.Cache;

namespace Storage.Operations.LicenseOperation;

public class LicenseOperation : ILicenseOperation
{
    public AllCache Cache { get; set; }

    public Credentials GetCredentials(string password)
    {
        var waiter = Helper.WaiterByPassword(Cache, password);
        return waiter is not null ? new Credentials(waiter.Id) : default;
    }
}