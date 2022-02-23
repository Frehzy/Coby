using System;

namespace Storage.Entities;

public interface IProduct
{
    Guid Id { get; }

    string ProductName { get; }

    decimal Price { get; }
}