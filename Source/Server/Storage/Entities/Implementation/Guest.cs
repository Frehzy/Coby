using Shared.Exceptions;
using Storage.Entities.Interface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.Implementation;

internal class Guest : IGuest
{
    private readonly ConcurrentDictionary<Guid, IProduct> _products = new();

    public Guid Id { get; }

    public string Name { get; }

    public IReadOnlyCollection<IProduct> Products => _products.Values.ToList();

    public IProduct TryAddProduct(IProduct product)
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

    public Guest(Guid guestId, string name, List<IProduct> products)
    {
        Id = guestId;
        Name = name;
        foreach (var product in products)
            _products.TryAdd(product.Id, product);
    }
}