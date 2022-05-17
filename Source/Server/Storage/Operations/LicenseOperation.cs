using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;

namespace Storage.Operations;

public class LicenseOperation
{
    public AllCache Cache { get; set; }

    public Credentials GetCredentials(string password, out Credentials credentials) =>
        credentials = Helper.WaiterByPassword(Cache, password, out var waiterOnCache) is not null
            ? new Credentials(waiterOnCache.Id)
            : throw new UserSessionInvalidException(password);

    public Credentials TryGetCredentials(string password) =>
        Helper.WaiterByPassword(Cache, password, out var waiterOnCache) is not null
            ? new Credentials(waiterOnCache.Id)
            : default;
}