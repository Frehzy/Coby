﻿using Shared.Dto.Enities;
using System;

namespace Storage.Operations.WaiterOperation;

public interface IWaiterOperation
{
    Waiter CreateWaiter(string name, string password);

    Waiter GetWaiterById(Guid waiterId);

    Waiter OpenPersonalShift(Guid waiterId);

    Waiter ClosePersonalShift(Guid waiterId);
}