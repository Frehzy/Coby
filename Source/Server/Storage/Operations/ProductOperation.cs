using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Operations;

public class ProductOperation
{
    public Order Order { get; }

    public List<Product> Products { get; }

    public ProductOperation(Order order, List<Product> products)
    {
        Order = order;
        Products = products;
    }

    public Product AddProductOnOrder(Guid guestId, Guid productId)
    {
        if (Order.Guests.TryGetValue(guestId, out var guests) is false)
            throw new EntityNotFound(guestId);

        var product = Products.FirstOrDefault(x => x.Id.Equals(productId));
        if (product is null)
            throw new EntityNotFound(productId);


        int maxRank = guests.GetProducts().Count();
        guests.Products.Add(maxRank + 1, product);

        return product;
    }

    public void RemoveProductOnOrder(Guid guestId, Guid productId, int rank)
    {
        if (Order.Guests.TryGetValue(guestId, out var guests) is false)
            throw new EntityNotFound(guestId);

        var removeProductList = guests.Products.Where(x => x.Key.Equals(rank) && x.Value.Id.Equals(productId))
                                               .ToDictionary(x => x.Key, x => x.Value);
        foreach (var product in removeProductList)
            guests.Products.Remove(product.Key);
    }
}