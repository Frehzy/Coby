using System;

namespace Shared.Entities.Dto;

public class WaiterDto
{
    public Guid Id { get; }

    public string Name { get; }

    public string Password { get; }

    public WaiterDto(Guid id, string name, string password)
    {
        Id = id;
        Name = name;
        Password = password;
    }
}