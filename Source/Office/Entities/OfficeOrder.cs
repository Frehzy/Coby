using System;

namespace Office.Entities;

internal class OfficeOrder
{
    public Guid OrderId { get; }

    public string Waiter { get; }

    public int TableNumber { get; }

    public decimal Sum { get; }

    public int GuestsCount { get; }

    public DateTime StartTime { get; }

    public DateTime? EndTime { get; }

    public OfficeOrder(Guid orderId, string waiter, int tableNumber, decimal sum, int guestsCount, DateTime startTime, DateTime? endTime)
    {
        OrderId = orderId;
        Waiter = waiter;
        TableNumber = tableNumber;
        Sum = sum;
        GuestsCount = guestsCount;
        StartTime = startTime;
        EndTime = endTime;
    }
}