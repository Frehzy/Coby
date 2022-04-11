using Shared.Dto.Enums;
using System;

namespace Shared.Dto.Enities;

public class DangerousOperationsDto
{
    public Guid OperationId { get; set; }

    public Guid WaiterId { get; set; }

    public string Message { get; set; }

    public DateTime Created { get; set; }

    public DangerousOperationEnum DangerousOperationEnum { get; set; }

    public DangerousOperationsDto() { }

    public DangerousOperationsDto(Guid operationId, Guid waiterId, string message, DateTime createdTime)
    {
        OperationId = operationId;
        WaiterId = waiterId;
        Message = message;
        Created = createdTime;
        DangerousOperationEnum = DangerousOperationEnum.AddedOnDB;
    }

    public DangerousOperationsDto(Guid waiterId, string message)
    {
        OperationId = Guid.NewGuid();
        WaiterId = waiterId;
        Message = message;
        Created = DateTime.Now;
        DangerousOperationEnum = DangerousOperationEnum.NotAdded;
    }

    public void SetDangerousOperationEnum(DangerousOperationEnum dangerousOperationEnum) =>
        DangerousOperationEnum = dangerousOperationEnum;
}