using System;

namespace Shared.Dto.Exceptions;

public class UserSessionInvalidException : ApiException
{
    private UserSessionInvalidException() { }

    public UserSessionInvalidException(string password) : base($"Unsuccessful attempt to get session. Password: [{password}]") { }

    public UserSessionInvalidException(Guid waiterId) : base($"Unsuccessful attempt to get session. WaiterId: [{waiterId}]") { }

    public UserSessionInvalidException(string message, Exception exception) : base(message, exception) { }
}