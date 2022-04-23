using System;

namespace Shared.Dto.Exceptions;

public class BaseException : Exception
{
    public BaseException() { }

    public virtual new string Message { get; private set; }

    public virtual void SetMessage(string message) => Message = message;
}