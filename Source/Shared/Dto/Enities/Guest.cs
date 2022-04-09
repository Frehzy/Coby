#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

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
        Products = new Dictionary<int, Product>();
    }

    public List<Product> GetProducts() => (Products?.Values ?? Enumerable.Empty<Product>()).ToList();
}