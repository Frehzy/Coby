using Storage.Cache.License;
using Storage.Cache.Waiters;
using Storage.Entities;
using Storage.Entities.EntityCreater;
using Storage.Exceptions;
using System;
using System.Linq;

namespace Storage.Operations.Implementation;

public class LicenseOperation : ILicenseOperation
{
    public ILicensesCache LicensesCache { get; }

    public IWaitersCache WaitersCache { get; }

    public LicenseOperation(ILicensesCache licensesCache, IWaitersCache waitersCache)
    {
        LicensesCache = licensesCache;
        WaitersCache = waitersCache;
    }

    public ICredentials GetCredentials(Guid userId, string password) =>
        WaitersCache.Waiters.SingleOrDefault(x => x.Id.Equals(userId) && x.Password.Equals(password)) is not null
        ? new Credentials(userId)
        : throw new EntityNotFound(userId);
}