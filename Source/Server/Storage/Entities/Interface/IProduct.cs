using System;

namespace Storage.Entities.Interface;

public interface IProduct
{
    Guid Id { get; }

    string ProductName { get; }

    decimal Price { get; }
}