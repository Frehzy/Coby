#nullable enable

using Shared.Dto.Enities;
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
    Table AddTable(Table table);

    [OperationContract]
    Table? RemoveTable(Guid tableId);
}