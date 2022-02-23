using System;

namespace Storage.Entities.EntityCreater;

internal class Waiter : IWaiter
{
    public Guid Id { get; }

    public string Name { get; }

    public string Password { get; }

    public Waiter(Guid id, string name, string password)
    {
        Id = id;
        Name = name;
        Password = password;
    }
}