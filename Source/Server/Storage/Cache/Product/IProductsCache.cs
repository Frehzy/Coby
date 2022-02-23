#nullable enable

using Storage.Entities;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Product;

public interface IProductsCache
{
    IReadOnlyList<IProduct> Products { get; }

    IProduct TryAdd(IProduct product);

    void TryRemove(Guid productId);

    IProduct? TryFind(Guid productId);
}