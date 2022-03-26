﻿using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.GetBy;

public class GetProduct
{
    public AllCache Cache { get; }

    public GetProduct(AllCache cache) =>
        Cache = cache;

    public Product GetProductById(Guid productId) =>
        Helper.ProductById(Cache, productId, out Product productOnCache) is null
            ? throw new EntityNotFound(productId)
            : productOnCache;

    public List<Product> GetProducts() =>
        Cache.ProductsCache.GetProductsCache();

    public Product? TryGetProductById(Guid productId) =>
        Helper.ProductById(Cache, productId, out Product productOnCache) is null
            ? default
            : productOnCache;
}