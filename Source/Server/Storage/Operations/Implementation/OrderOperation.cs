using Storage.Cache.License;
using Storage.Cache.Order;
using Storage.Cache.Table;
using Storage.Cache.Waiters;
using Storage.Entities;
using Storage.Entities.EntityCreater;
using Storage.Enums;
using Storage.Exceptions;

namespace Storage.Operations.Implementation;

internal class OrderOperation : IOrderOperation
{
    public ILicensesCache LicensesCache { get; }
    public IWaitersCache WaitersCache { get; }
    public ITablesCache TablesCache { get; }
    public IOrdersCache OrdersCache { get; }

    public OrderOperation(ILicensesCache licensesCache,
                          IWaitersCache waitersCache,
                          ITablesCache tablesCache,
                          IOrdersCache ordersCache)
    {
        LicensesCache = licensesCache;
        WaitersCache = waitersCache;
        TablesCache = tablesCache;
        OrdersCache = ordersCache;
    }

    public IOrder CreateOrder(ICredentials credentials, IWaiter waiter, ITable table)
    {
        if (LicensesCache.TryFind(credentials.WaiterId) is null)
            throw new EntityNotFound(credentials.WaiterId);

        var order = new Order(table, waiter, OrderStatus.New);
        return OrdersCache.TryAdd(order);
    }
}