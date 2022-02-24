using System;
using System.Collections.Generic;

namespace Storage.Entities.Interface;

public interface IGuest
{
    Guid Id { get; }

    string Name { get; }

    IReadOnlyCollection<IProduct> Products { get; }

    IProduct TryAddProduct(IProduct product);

    void TryRemoveProduct(Guid id);
}