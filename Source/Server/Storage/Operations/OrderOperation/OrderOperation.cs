using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using Storage.Operations.PaymentOperation;
using System;
using System.Collections.Generic;

namespace Storage.Operations.OrderOperation;

public class OrderOperation : IOrderOperation
{
    public AllCache Cache { get; set; }

    public GuestOperations GetGuestOperations(Order order) => new(Cache, order);

    public PaymentOperations GetPaymentOperations(Order order) => new(Cache, order, Cache.PaymentTypesCache.GetPaymentTypesCache());

    public ProductOperation GetProductOperation(Order order) => new(Cache, order, Cache.ProductsCache.GetProductsCache());

    public Order CreateOrder(Credentials credentials, Table table)
    {
        if (Helper.CheckLicense(Cache, credentials, out _) is null)
            throw new EntityNotFound(credentials.WaiterId);

        Helper.WaiterById(Cache, credentials.WaiterId, out Waiter waiterOnCache);
        return Cache.OrdersCache.AddOrUpdateOrder(new Order(Guid.NewGuid(), table, waiterOnCache));
    }

    public List<Order> GetOrders() =>
        Cache.OrdersCache.GetOrdersCache();

    public bool RemoveOrder(Credentials credentials, Guid orderId)
    {
        if (Helper.CheckLicense(Cache, credentials, out var license) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Helper.OrderById(Cache, orderId, out _) is null)
            throw new EntityNotFound(orderId);

        Cache.DangerousOperationCache.AddDangerousOperations(new(license.Id, $"Remove order [{orderId}]"));
        return Cache.OrdersCache.RemoveOrder(orderId);
    }

    public Order SaveOrder(Order order) =>
        Cache.OrdersCache.AddOrUpdateOrder(order);

    public void CloseOrder(Credentials credentials, Guid orderId)
    {
        if (Helper.CheckLicense(Cache, credentials, out _) is null)
            throw new EntityNotFound(credentials.WaiterId);

        if (Helper.OrderById(Cache, orderId, out Order orderOnCache) is null)
            throw new EntityNotFound(orderId);

        orderOnCache.Status = OrderStatus.Closed;
        orderOnCache.EndTime = DateTime.Now;
        Cache.OrdersCache.AddOrUpdateOrder(orderOnCache);
    }
}