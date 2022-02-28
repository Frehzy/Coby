using System;
using System.Collections.Generic;

namespace Shared.Dto.Enities;

public class Guest
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Dictionary<Guid, Product> Products { get; set; }

    public Guest() { }

    /*public Product TryAddProduct(Product product) =>
        Products.TryAdd(product.Id, product);

    public Product AddOrUpdate(Product product) =>
        Products.AddOrUpdate(product.Id, product);

    public bool TryRemoveProduct(Guid productId) =>
        Products.TryRemove(productId) ? true : throw new EntityNotFound(productId);*/
}