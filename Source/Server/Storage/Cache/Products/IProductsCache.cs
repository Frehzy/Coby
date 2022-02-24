using Storage.Entities.Interface;
using System;
using System.Collections.Generic;

namespace Storage.Cache.Products;

public interface IProductsCache
{
    public IReadOnlyCollection<IProduct> Products { get; }

    public IProduct TryAdd(IProduct product);

    public IProduct TryFind(Guid productId);

    public void TryRemove(Guid productId);
}