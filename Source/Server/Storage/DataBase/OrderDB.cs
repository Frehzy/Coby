using System;

namespace Storage.DataBase;

internal class OrderDB
{
    public Guid Id { get; set; }

    public Guid TableId { get; set; }

    public Guid WaiterId { get; set; }

    public decimal Sum { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public OrderDB() { }

    public OrderDB(Guid id, Guid tableId, Guid waiterId, decimal sum, DateTime startTime, DateTime endTime)
    {
        Id = id;
        TableId = tableId;
        WaiterId = waiterId;
        Sum = sum;
        StartTime = startTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        EndTime = endTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
    }
}