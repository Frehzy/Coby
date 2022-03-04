using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations;

public class ProductOperation
{
    public AllCache Cache { get; set; }

    public Product AddProductOnOrder(Guid orderId, Guid guestId, Guid productId)
    {
        if (Helper.GuestOnOrderById(Cache, orderId, guestId, out Order sourceOrder, out Guest guest) is null)
            throw new EntityNotFound(guestId);

        if (Helper.ProductById(Cache, productId, out Product productOnCache) is null)
            throw new EntityNotFound(productId);

        var orderProducts = sourceOrder.Guests.First(x => x.Value.Id.Equals(guest.Id)).Value.Products;
        int maxRank = orderProducts.Keys.Max();
        orderProducts.Add(maxRank + 1, productOnCache);

        return productOnCache;
    }

    public void RemoveProductOnOrder(Guid orderId, Guid guestId, Guid productId, int rank)
    {
        if (Helper.GuestOnOrderById(Cache, orderId, guestId, out Order sourceOrder, out Guest guest) is null)
            throw new EntityNotFound(guestId);

        sourceOrder.Guests
            .First(x => x.Value.Id.Equals(guest.Id)).Value.Products
            .Where(x => x.Key.Equals(rank) && x.Value.Id.Equals(productId));
    }
}