#nullable enable

using Shared.Dto.Enities;
using Storage.Entities.Implementation;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface ITableCache
{
    [OperationContract]
    List<Table> GetTablesCache();

    [OperationContract]
    TableDto AddTable(Table table);

    [OperationContract]
    TableDto? RemoveTable(Guid tableId);
}