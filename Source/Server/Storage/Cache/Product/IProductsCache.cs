using Storage.Entities;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Product;

public interface IProductsCache
{
    IReadOnlyCollection<IProduct> Products { get; }

    IProduct TryAdd(IProduct product);

    void TryRemove(Guid productId);

    IProduct? TryFind(Guid productId);
}