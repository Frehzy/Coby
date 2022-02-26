using Storage.Entities.Interface;
using System;

namespace Storage.DataBase.ConvertType;

internal class WaiterType : IWaiter
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public WaiterType() { }
}