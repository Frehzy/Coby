using Shared.Dto.Enities;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetProduct
{
    public AllCache Cache { get; }

    public GetProduct(AllCache cache) =>
        Cache = cache;

    public Product TryGetProductById(Guid productId) =>
        Helper.ProductById(Cache, productId, out Product productOnCache) is null
            ? default
            : productOnCache;

    public List<Product> GetProducts() =>
        Cache.ProductsCache.GetProductsCache();
}