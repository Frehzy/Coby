﻿using Shared.Dto.Enities;

namespace Storage.Operations.OrderOperation;

public interface IOrderOperation
{
    Order CreateOrder(Credentials credentials, Waiter waiter, Table table);
}