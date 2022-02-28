using System;
using System.Collections.Generic;

namespace Shared.Dto.Enities;

public class Guest
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Dictionary<int, Product> Products { get; set; }

    public Guest() { }

    public Guest(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}