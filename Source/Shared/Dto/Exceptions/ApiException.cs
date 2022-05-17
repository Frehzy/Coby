using System;
using System.Runtime.Serialization;

namespace Shared.Dto.Exceptions;

[Serializable]
public abstract class ApiException : Exception
{
    protected ApiException() : base() { }

    protected ApiException(string message) : base(message) { }

    protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    protected ApiException(string message, Exception exception) : base(message, exception) { }
}