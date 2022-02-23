using Storage.Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Entities.EntityCreater
{
    internal class Guest : IGuest
    {
        private readonly ConcurrentDictionary<Guid, IProduct> _products = new();

        public Guid Id { get; }

        public string Name { get; }

        public IReadOnlyList<IProduct> Products => _products.Values.ToList();

        public Guest(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public IProduct AddProduct(IProduct product) =>
            _products.TryAdd(product.Id, product)
            ? product
            : throw new EntityNotFound(product.Id);

        public void RemoveProduct(Guid productId)
        {
            if (_products.TryRemove(productId, out _) is false)
                throw new EntityNotFound(productId);
        }
    }
}