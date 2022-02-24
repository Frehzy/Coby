using System;

namespace Shared.Exceptions;

public class LicenseException : BaseException
{
    public LicenseException(Guid licenceId) =>
        base.SetMessage($"License [{licenceId}] cannot be used.");
}
