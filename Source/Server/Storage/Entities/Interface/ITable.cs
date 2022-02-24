using System;

namespace Storage.Entities.Interface;

public interface ITable
{
    Guid Id { get; }

    int TableNumber { get; }
}