using System;

namespace Shared.Dto.Exceptions;

public class BaseException : Exception
{
    private string _message;

    public BaseException() { }

    public virtual string GetMessage => _message;

    public virtual void SetMessage(string message) => _message = message;
}