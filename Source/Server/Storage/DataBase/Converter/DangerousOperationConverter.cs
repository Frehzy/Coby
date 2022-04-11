using Shared.Dto.Enities;
using System;

namespace Storage.DataBase.Converter;

internal static class DangerousOperationConverter
{
    public static DangerousOperationsDto Converter(DangerousOperationDB dangerousOperation) =>
        new(dangerousOperation.OperationId,
            dangerousOperation.WaiterId,
            dangerousOperation.Message,
            DateTime.Parse(dangerousOperation.Created));
}