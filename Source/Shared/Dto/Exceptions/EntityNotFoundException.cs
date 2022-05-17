using System;

namespace Shared.Dto.Exceptions;

[Serializable]
public class EntityNotFoundException : EntityUsingException
{
    private EntityNotFoundException() { }

    public EntityNotFoundException(Guid entityId, Type entityType)
        : base(entityId, entityType, $"{entityType.Name} not found.", new EntityNotFoundException())
    {
        Log.Error(this);
    }
}