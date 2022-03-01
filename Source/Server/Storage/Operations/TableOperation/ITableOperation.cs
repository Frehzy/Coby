using Shared.Dto.Enities;
using System;

namespace Storage.Operations.TableOperation;

public interface ITableOperation
{
    Table CreateTable(int tableNumber);

    Table GetTableById(Guid tableId);
}