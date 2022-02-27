using Shared.Dto.Exceptions;
using Storage.Cache;
using Storage.Entities.Implementation;
using System;
using System.Linq;

namespace Storage.Operations.LicenseOperation;

public class LicenseOperation : ILicenseOperation
{
    public AllCache Cache { get; set; }

    public Credentials GetCredentials(Guid userId, string password, AllCache cache) =>
        cache.WaitersCache.GetWaitersCache().SingleOrDefault(x => x.Id.Equals(userId) && x.Password.Equals(password)) is not null
        ? new Credentials(userId)
        : throw new EntityNotFound(userId);
}