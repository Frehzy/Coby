using Storage.Cache;
using Storage.Entities.Implementation;
using System;
using System.Linq;

namespace Storage.Operations.LicenseOperation;

public class LicenseOperation : ILicenseOperation
{
    public AllCache Cache { get; set; }

    public Credentials GetCredentials(string password)
    {
        if (Cache is null)
            throw new ArgumentNullException("Cache cannot be null.");

        var waiter = Cache.WaitersCache.GetWaitersCache()
                                       .FirstOrDefault(x => x.Password.Equals(password));
        return waiter is not null ? new Credentials(waiter.Id) : default;
    }
}