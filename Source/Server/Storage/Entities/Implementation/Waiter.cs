using Shared.Dto.Enums;
using System;

namespace Storage.Entities.Implementation;

public class Waiter
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public WaiterSessionStatus Status { get; set; }

    public Waiter() { }

    public Waiter(Guid waiterId, string name, string password, WaiterSessionStatus status)
    {
        Id = waiterId;
        Name = name;
        Password = password;
        Status = status;
    }
}