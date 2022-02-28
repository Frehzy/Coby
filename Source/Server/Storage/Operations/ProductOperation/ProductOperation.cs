using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations.ProductOperation;

public class ProductOperation : IProductOperation
{
    public AllCache Cache { get; set; }

    public Product CreateProduct(string productName, decimal price, bool isItForSale)
    {
        if (Helper.ProductByName(Cache, productName, out Product productOnCache) is not null)
            throw new EntityAlreadyExistsException(productOnCache.Id);

        return Cache.ProductsCache.AddProduct(new Product(Guid.NewGuid(), productName, price, isItForSale));
    }

    public Product AddProductOnOrder(Guid orderId, Guid guestId, Guid productId)
    {
        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        if (Helper.GuestOnOrderById(Cache, orderId, guestId, out Guest guest) is null)
            throw new EntityNotFound(guestId);

        if (Helper.ProductById(Cache, productId, out Product productOnCache) is null)
            throw new EntityNotFound(productId);

        var orderProducts = orderOnCache.Guests.First(x => x.Value.Id.Equals(guest.Id)).Value.Products;
        int maxRank = orderProducts.Keys.Max();
        orderProducts.Add(maxRank + 1, productOnCache);
        return productOnCache;
    }

    public void RemoveProductOnOrder(Guid orderId, Guid guestId, Guid productId, int rank)
    {
        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        if (Helper.GuestOnOrderById(Cache, orderId, guestId, out Guest guest) is null)
            throw new EntityNotFound(guestId);

        orderOnCache.Guests
            .First(x => x.Value.Id.Equals(guest.Id)).Value.Products
            .Where(x => x.Key.Equals(rank) && x.Value.Id.Equals(productId));
    }
}