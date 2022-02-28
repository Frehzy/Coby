using Shared.Dto.Enities;

namespace Storage.Operations.TableOperation;

public interface ITableOperation
{
    Table CreateTable(int tableNumber);
}