using Shared;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage.Operations.OrderOperation;

public class ProductOperation
{
    public AllCache Cache { get; }

    public Order Order { get; }

    public List<Product> Products { get; }

    public ProductOperation(AllCache cache, Order order, List<Product> products)
    {
        Cache = cache;
        Order = order;
        Products = products;
    }

    public Product AddProductOnOrder(Credentials credentials, Guid guestId, Guid productId)
    {
        if (Helper.CheckLicense(Cache, credentials, out var license) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Order.Guests.TryGetValue(guestId, out var guests) is false)
            throw new EntityNotFound(guestId);

        var product = Products.FirstOrDefault(x => x.Id.Equals(productId));
        if (product is null)
            throw new EntityNotFound(productId);

        int maxRank = guests.Products.DefaultIfEmpty().Max(x => x.Key);
        guests.Products.Add(maxRank + 1, product);
        HistoryHelper.OrderHistory(Order, product.Id, Entities.Product, ActionsEnum.Added);
        Log.Info($"{nameof(Product)} added on order {Order.Id}. {Log.GetFormatProperties(product)}");
        return product;
    }

    public void RemoveProductOnOrder(Credentials credentials, Guid guestId, Guid productId, int rank)
    {
        if (Helper.CheckLicense(Cache, credentials, out var license) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Order.Guests.TryGetValue(guestId, out var guests) is false)
            throw new EntityNotFound(guestId);

        var product = guests.GetProducts().First(x => x.Id.Equals(productId));
        Cache.DangerousOperationCache.AddDangerousOperations(new(license.Id, $"Remove product [{product.ProductName}]:[{product.Id}] on order [{Order.Id}]"));
        guests.Products.Remove(rank);
        Log.Info($"{nameof(Product)} remove on order {Order.Id}. {Log.GetFormatProperties(product)}");
        HistoryHelper.OrderHistory(Order, productId, Entities.Product, ActionsEnum.Remove);
    }
}