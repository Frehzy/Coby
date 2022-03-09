using Shared.Dto.Enities;
using Shared.Dto.Enums;
using System;

namespace Storage.Operations;

internal static class HistoryHelper
{
    public static void OrderHistory(Order order, Guid targetId, Entities targetEntity, ActionsEnum actions)
    {
        var history = new History(Guid.NewGuid(), order.Id, targetId, targetEntity, actions);
        order.OrderHistories.Add(history.HistoryId, history);
    }
}