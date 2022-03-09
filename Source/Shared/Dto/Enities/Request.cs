using Shared.Dto.Enums;
using System;

namespace Shared.Dto.Enities;

public class Request
{
    public Guid Id { get; set; }

    public RequestStatus Status { get; set; }

    public string Message { get; set; }

    public Exception Exception { get; set; }

    public Request() { }

    public Request(Guid id, RequestStatus status, string message)
    {
        Id = id;
        Status = status;
        Message = message;
    }
}