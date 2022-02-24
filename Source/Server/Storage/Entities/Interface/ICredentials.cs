using System;

namespace Storage.Entities.Interface;

public interface ICredentials
{
    Guid WaiterId { get; }
}