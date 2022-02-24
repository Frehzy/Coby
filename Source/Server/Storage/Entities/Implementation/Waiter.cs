using Storage.Entities.Interface;
using System;

namespace Storage.Entities.Implementation;

public class Waiter : IWaiter
{
    public Guid Id { get; }

    public string Name { get; }

    public string Password { get; }

    public Waiter(Guid waiterId, string name, string password)
    {
        Id = waiterId;
        Name = name;
        Password = password;
    }
}