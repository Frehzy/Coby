using System;

namespace Storage.Exceptions;

internal class EntityNotFound : BaseException
{
    public EntityNotFound(Guid id) =>
        base.SetMessage($"Entity [{id}] not found.");
}