using Shared.Dto.Exceptions;
using System;
using System.Collections.Generic;

namespace Storage.Entities.Implementation;

public class Guest
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Dictionary<Guid, Product> Products { get; set; }

    public Guest() { }

    public Guest(Guid guestId, string name, List<Product> products)
    {
        Id = guestId;
        Name = name;
        products.ForEach(x => Products.Add(x.Id, x));
    }

    public Product TryAddProduct(Product product) =>
        Products.TryAdd(product.Id, product);

    public Product AddOrUpdate(Product product) =>
        Products.AddOrUpdate(product.Id, product);

    public bool TryRemoveProduct(Guid productId) =>
        Products.TryRemove(productId) ? true : throw new EntityNotFound(productId);
}