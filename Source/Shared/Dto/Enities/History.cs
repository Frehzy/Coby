using System;

namespace Shared.Dto.Enities;

public class History
{
    public Guid Id { get; set; }

    public Guid ObjectId { get; set; }

    public string Message { get; set; }

    public History() { }

    public History(Guid historyId, Guid objectId, string message)
    {
        Id = historyId;
        ObjectId = objectId;
        Message = message;
    }
}