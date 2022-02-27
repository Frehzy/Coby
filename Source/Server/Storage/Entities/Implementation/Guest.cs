using Shared.Dto.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.Implementation;

public class Guest
{
    private readonly ConcurrentDictionary<Guid, Product> _products = new();

    public Guid Id { get; set; }

    public string Name { get; set; }

    public IReadOnlyCollection<Product> Products => _products.Values.ToList();

    public Guest() { }

    public Guest(Guid guestId, string name, List<Product> products)
    {
        Id = guestId;
        Name = name;
        foreach (var product in products)
            _products.TryAdd(product.Id, product);
    }

    public Product TryAddProduct(Product product)
    {
        var result = _products.TryAdd(product.Id, product)
            ? product
            : throw new OverflowException($"An element with the same Guid [{product.Id}] already exists.");
        return result;
    }

    public void TryRemoveProduct(Guid productId)
    {
        if (_products.TryRemove(productId, out _) is false)
            throw new EntityNotFound(productId);
    }
}