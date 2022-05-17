using System;

namespace Shared.Dto.Exceptions;

[Serializable]
public sealed class PermissionDeniedException : EntityUsingException
{
    private PermissionDeniedException() { }

    public PermissionDeniedException(Guid entityId, Type entityType)
        : base(entityId, entityType, $"No required permissions", new PermissionDeniedException())
    {
        Log.Error(this);
    }
}