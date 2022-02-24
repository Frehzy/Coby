using System;

namespace Storage.Exceptions;

public class EntityNotFound : BaseException
{
    public EntityNotFound(Guid id) =>
        base.SetMessage($"Entity [{id}] not found.");
}