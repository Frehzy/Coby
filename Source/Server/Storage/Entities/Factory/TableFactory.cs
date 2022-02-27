using Shared.Dto.Enities;
using Storage.Entities.Implementation;

namespace Storage.Entities.Factory;

internal static class TableFactory
{
    public static TableDto CreateDto(Table table) =>
        new()
        {
            Id = table.Id,
            TableNumber = table.TableNumber,
        };

    public static Table Create(TableDto tableDto) =>
        new(tableDto.Id, tableDto.TableNumber);
}