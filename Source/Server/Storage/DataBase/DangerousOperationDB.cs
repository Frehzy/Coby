using Shared.Dto.Enities;
using System;

namespace Storage.DataBase;

internal class DangerousOperationDB
{
    public Guid OperationId { get; set; }

    public Guid WaiterId { get; set; }

    public string Message { get; set; }

    public string Created { get; set; }

    public DangerousOperationDB() { }

    public DangerousOperationDB(Guid operationId, Guid waiterId, string message, DateTime createdTime)
    {
        OperationId = operationId;
        WaiterId = waiterId;
        Message = message;
        Created = createdTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
    }

    public DangerousOperationDB(DangerousOperationsDto dangerousOperationsDto)
    {
        OperationId = dangerousOperationsDto.OperationId;
        WaiterId = dangerousOperationsDto.WaiterId;
        Message = dangerousOperationsDto.Message;
        Created = dangerousOperationsDto.Created.ToString("yyyy-MM-dd HH:mm:ss.fff");
    }
}