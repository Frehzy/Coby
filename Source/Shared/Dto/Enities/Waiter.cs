using Shared.Dto.Enums;
using System;

namespace Shared.Dto.Enities;

public class Waiter
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public PermissionStatus PermissionStatus { get; set; }

    public WaiterSessionStatus Status { get; set; }

    public Waiter() { }

    public Waiter(Guid waiterId, string name, string password, PermissionStatus permissionStatus, WaiterSessionStatus status)
    {
        Id = waiterId;
        Name = name;
        Password = password;
        PermissionStatus = permissionStatus;
        Status = status;
    }
}