using System;

namespace Shared.Dto.Enities;

public class DangerousOperationsDto
{
    public Guid OperationId { get; set; }

    public Guid WaiterId { get; set; }

    public string Message { get; set; }

    public string Created { get; set; }

    public DangerousOperationsDto() { }

    public DangerousOperationsDto(Guid waiterId, string message)
    {
        OperationId = Guid.NewGuid();
        WaiterId = waiterId;
        Message = message;
        Created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"); ;
    }

    public DateTime GetTime() => DateTime.Parse(Created);
}