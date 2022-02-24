using System;

namespace Storage.Entities.Interface;

public interface IWaiter
{
    Guid Id { get; }

    string Name { get; }

    string Password { get; }
}