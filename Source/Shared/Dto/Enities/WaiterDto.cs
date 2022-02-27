using Shared.Dto.Enums;
using System;

namespace Shared.Dto.Enities;

public record WaiterDto
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public string Password { get; init; }

    public WaiterSessionStatus Status { get; init; }

    public WaiterDto() { }

    public WaiterDto(Guid waiterId, string name, string password, WaiterSessionStatus status)
    {
        Id = waiterId;
        Name = name;
        Password = password;
        Status = status;
    }
}