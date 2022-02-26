using Storage.Cache;
using Storage.DataBase;
using Storage.DataBase.ConvertType;
using Storage.Operations;
using System;
using System.Collections.Generic;

namespace Storage.Host;

public class ClientInstance
{
    public AllCache Cache { get; }

    public AllOperations Operations { get; }

    internal DBInteraction DB { get; }

    public ClientInstance()
    {
        List<Guid> g = new();
        for (int i = 0; i < 10; i++)
            g.Add(Guid.NewGuid());

        Cache = new AllCache();
        Operations = new AllOperations(Cache);
        DB = new("localhost", "coby", 3306, "coby", "1234");
        
        GetTables().ForEach(x => Cache.TablesCache.TryAdd(x));
        GetPaymentTypes().ForEach(x => Cache.PaymentTypeCache.TryAdd(x));
        GetWaiters().ForEach(x => Cache.WaitersCache.TryAdd(x));
        GetProducts().ForEach(x => Cache.ProductsCache.TryAdd(x));
    }

    internal List<TableType> GetTables() =>
        DB.SqlQuery<TableType>("SELECT * FROM tables");

    internal List<PaymentType> GetPaymentTypes() =>
        DB.SqlQuery<PaymentType>("SELECT * FROM paymentTypes");

    internal List<WaiterType> GetWaiters() =>
        DB.SqlQuery<WaiterType>("SELECT * FROM waiters");

    internal List<ProductType> GetProducts() =>
        DB.SqlQuery<ProductType>("SELECT * FROM `products` WHERE IsItForSale=1");
}