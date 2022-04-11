using System;

namespace Storage.DataBase;

public class WaiterDB
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public string PermissionStatus { get; set; }

    public WaiterDB() { }
}