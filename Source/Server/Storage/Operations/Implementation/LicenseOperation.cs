using Shared.Exceptions;
using Storage.Cache;
using Storage.Entities.Implementation;
using Storage.Entities.Interface;
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Storage.Operations.Implementation;

[DataContract]
public class LicenseOperation : ILicenseOperation
{
    [DataMember]
    public LicensesCache LicensesCache { get; }

    [DataMember]
    public WaitersCache WaitersCache { get; }

    public LicenseOperation(LicensesCache licensesCache, WaitersCache waitersCache)
    {
        LicensesCache = licensesCache;
        WaitersCache = waitersCache;
    }

    [OperationContract]
    public ICredentials GetCredentials(Guid userId, string password) =>
        WaitersCache.Waiters.SingleOrDefault(x => x.Id.Equals(userId) && x.Password.Equals(password)) is not null
        ? new Credentials(userId)
        : throw new EntityNotFound(userId);
}