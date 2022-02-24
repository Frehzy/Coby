using Shared.Dto;
using Storage.Entities.Interface;

namespace Storage.Entities.ConverterToDto;

internal class ToTableDto
{
    public ITable Table { get; }

    public ToTableDto(ITable table) =>
        Table = table;

    public TableDto Convert() =>
        new(Table.Id, Table.TableNumber);
}