using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Operations.OrderOperation;

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


        int maxRank = guests.Products.DefaultIfEmpty().Max(x => x.Key);
        guests.Products.Add(maxRank + 1, product);
        HistoryHelper.OrderHistory(Order, product.Id, Entities.Product, ActionsEnum.Added);
        return product;
    }

    public void RemoveProductOnOrder(Guid guestId, Guid productId, int rank)
    {
        if (Order.Guests.TryGetValue(guestId, out var guests) is false)
            throw new EntityNotFound(guestId);

        guests.Products.Remove(rank);
        HistoryHelper.OrderHistory(Order, productId, Entities.Product, ActionsEnum.Remove);
    }
}