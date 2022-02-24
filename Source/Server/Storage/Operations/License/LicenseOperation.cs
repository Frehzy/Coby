using Storage.Cache;
using Storage.Entities.Implementation;
using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using System.Linq;

namespace Storage.Operations.License;

public class LicenseOperation : ILicenseOperation
{
    public AllCache Cache { get; }

    public LicenseOperation(AllCache cache) =>
        Cache = cache;

    public ICredentials GetCredentials(Guid userId, string password) =>
        Cache.WaitersCache.Waiters.SingleOrDefault(x => x.Id.Equals(userId) && x.Password.Equals(password)) is not null
        ? new Credentials(userId)
        : throw new EntityNotFound(userId);
}