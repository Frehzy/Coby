using System;

namespace Storage.Entities;

public interface IWaiter
{
    Guid Id { get; }

    string Name { get; }

    string Password { get; }
}