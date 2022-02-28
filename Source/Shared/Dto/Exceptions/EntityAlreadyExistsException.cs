using System;
using System.Collections.Generic;

namespace Shared.Dto.Exceptions;

public class EntityAlreadyExistsException : BaseException
{
    public EntityAlreadyExistsException(Guid id) =>
        base.SetMessage($"Entity [{id}] already exists.");

    public EntityAlreadyExistsException(List<Guid> ids) =>
        base.SetMessage($"Entity [{string.Join("]-[", ids)}] already exists.");
}
