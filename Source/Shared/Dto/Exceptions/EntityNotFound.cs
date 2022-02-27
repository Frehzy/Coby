using System;

namespace Shared.Dto.Exceptions;

public class EntityNotFound : BaseException
{
    public EntityNotFound(Guid id) =>
        base.SetMessage($"Entity [{id}] not found.");
}