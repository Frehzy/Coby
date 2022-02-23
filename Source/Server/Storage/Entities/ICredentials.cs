using System;

namespace Storage.Entities;

public interface ICredentials
{
    Guid WaiterId { get; }
}