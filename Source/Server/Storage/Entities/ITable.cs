using System;

namespace Storage.Entities;

public interface ITable
{
    Guid Id { get; }

    int TableNumber { get; }
}