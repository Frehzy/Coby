using System;
using System.Collections.Generic;

namespace Shared.Dto.Exceptions;

[Serializable]
public class EntityAlreadyExistsException : EntityUsingException
{
    private EntityAlreadyExistsException() { }

    public EntityAlreadyExistsException(Guid entityId, Type entityType)
        : base(entityId, entityType, $"{entityType.Name} already exists.", new EntityAlreadyExistsException())
    {
        Log.Error(this);
    }

    public EntityAlreadyExistsException(List<Guid> entitiesId, Type entityType)
    {
        foreach (var entity in entitiesId)
            new EntityAlreadyExistsException(entity, entityType);
    }
}
