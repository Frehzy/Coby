﻿using System;
using System.Collections.Generic;

namespace Storage.Entities;

public interface IGuest
{
    Guid Id { get; }

    string Name { get; }

    IReadOnlyList<IProduct> Products { get; }

    IProduct AddProduct(IProduct product);

    void RemoveProduct(Guid id);
}