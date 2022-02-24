using Storage.Entities.Interface;
using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache.Products;

public class ProductsCache : IProductsCache
{
    private readonly ConcurrentDictionary<Guid, IProduct> _products = new();

    public IReadOnlyCollection<IProduct> Products => _products.Values.ToList();

    public IProduct TryAdd(IProduct product) =>
        _products.TryAdd(product.Id, product)
        ? product
        : throw new OverflowException($"An element with the same Guid [{product.Id}] already exists.");

    public IProduct TryFind(Guid productId) =>
        _products.TryGetValue(productId, out var license)
            ? license : default;

    public void TryRemove(Guid productId)
    {
        if (_products.TryRemove(productId, out _) is false)
            throw new EntityNotFound(productId);
    }
}