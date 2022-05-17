using System;

namespace Shared.Dto.Exceptions;

[Serializable]
public sealed class LicenseException : EntityUsingException
{
    private LicenseException() { }

    public LicenseException(Guid entityId, Type entityType)
        : base(entityId, entityType, $"Licence cannot be used.", new LicenseException())
    {
        Log.Error(this);
    }
}
