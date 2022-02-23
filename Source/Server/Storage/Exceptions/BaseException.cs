using System;

namespace Storage.Exceptions;

internal class BaseException : Exception
{
    private string _message;

    public BaseException() { }

    public virtual string GetMessage => _message;

    public virtual void SetMessage(string message) => _message = message;
}