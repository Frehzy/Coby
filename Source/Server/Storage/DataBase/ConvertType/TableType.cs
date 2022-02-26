using Storage.Entities.Interface;
using System;

namespace Storage.DataBase.ConvertType;

internal class TableType : ITable
{
    public Guid Id { get; set; }

    public int TableNumber { get; set; }

    public TableType() { }
}