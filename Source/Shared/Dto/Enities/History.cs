using Shared.Dto.Enums;
using System;

namespace Shared.Dto.Enities;

public class History
{
    public Guid HistoryId { get; set; }

    public Guid EntityId { get; set; }

    public Guid TargetId { get; set; }

    public string Message { get; set; }

    public string Created { get; set; }

    public History() { }

    public History(Guid historyId, Guid entityId, Guid targetId, Entities targetEntity, ActionsEnum actions)
    {
        HistoryId = historyId;
        EntityId = entityId;
        TargetId = targetId;
        Message = $"{targetEntity} has been {actions}";
        Created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
    }

    public DateTime GetTime() => DateTime.Parse(Created);
}