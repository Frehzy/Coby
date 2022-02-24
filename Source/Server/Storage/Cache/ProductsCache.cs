using Shared.Dto;
using Shared.Exceptions;
using Storage.Entities.ConverterToDto;
using Storage.Entities.Implementation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Cache;

public class ProductsCache
{
    private readonly ConcurrentDictionary<Guid, Product> _products = new();

    public IReadOnlyList<ProductDto> Products => _products.Values.Select(x => new ToProductDto(x).Convert()).ToList();

    public Product TryAdd(Product product) =>
        _products.TryAdd(product.Id, product)
        ? product
        : throw new OverflowException($"An element with the same Guid [{product.Id}] already exists.");

    public Product TryFind(Guid productId) =>
        _products.TryGetValue(productId, out var license)
            ? license : default;

    public void TryRemove(Guid productId)
    {
        if (_products.TryRemove(productId, out _) is false)
            throw new EntityNotFound(productId);
    }
}