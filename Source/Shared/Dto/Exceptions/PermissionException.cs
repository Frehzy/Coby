using System;

namespace Shared.Dto.Exceptions;

public class PermissionException : BaseException
{
    public PermissionException(Guid id)
    {
        base.SetMessage($"No required permissions. Entity [{id}]");
        Log.Error($"{nameof(PermissionException)}: {base.Message}");
    }
}