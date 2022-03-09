using Shared.Dto.Enums;
using System;
using System.Collections.Generic;

namespace Shared.Dto.Enities;

public class Request
{
    public List<Guid> Id { get; set; }

    public RequestStatus Status { get; set; }

    public string Message { get; set; }

    public Exception Exception { get; set; }

    public Request() { }

    public Request(Guid id, RequestStatus status, string message)
    {
        Id.Add(id);
        Status = status;
        Message = message;
    }

    public Request(List<Guid> idList, RequestStatus status, string message)
    {
        Id.AddRange(idList);
        Status = status;
        Message = message;
    }
}