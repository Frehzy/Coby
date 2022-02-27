using Shared.Dto.Enities;
using Storage.Cache;
using Storage.DataBase;
using Storage.Entities.Factory;
using Storage.Entities.Implementation;
using Storage.Operations.LicenseOperation;
using Storage.Operations.OrderOperation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Storage.Host;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    private readonly ConcurrentDictionary<Guid, LicenseDto> _licensesCache = new();
    private readonly ConcurrentDictionary<Guid, OrderDto> _ordersCache = new();
    private readonly ConcurrentDictionary<Guid, PaymentTypeDto> _paymentTypes = new();
    private readonly ConcurrentDictionary<Guid, ProductDto> _productsCache = new();
    private readonly ConcurrentDictionary<Guid, TableDto> _tablesCache = new();
    private readonly ConcurrentDictionary<Guid, WaiterDto> _waitersCache = new();
    private bool _canWork = true;

    public LicenseDto AddLicense(License license) =>
        _licensesCache.AddOrUpdate(license.Id, LicenceFactory.CreateDto(license), (key, oldValue) => LicenceFactory.CreateDto(license));

    public OrderDto AddOrder(Order order) =>
        _ordersCache.AddOrUpdate(order.Id, OrderFactory.CreateDto(order), (key, oldValue) => OrderFactory.CreateDto(order));

    public PaymentTypeDto AddPaymentType(PaymentType paymentType) =>
        _paymentTypes.AddOrUpdate(paymentType.Id, PaymentTypeFactory.CreateDto(paymentType), (key, oldValue) => PaymentTypeFactory.CreateDto(paymentType));

    public ProductDto AddProduct(Product product) =>
        _productsCache.AddOrUpdate(product.Id, ProductFactory.CreateDto(product), (key, oldValue) => ProductFactory.CreateDto(product));

    public TableDto AddTable(Table table) =>
        _tablesCache.AddOrUpdate(table.Id, TableFactory.CreateDto(table), (key, oldValue) => TableFactory.CreateDto(table));

    public WaiterDto AddWaiter(Waiter waiter) =>
        _waitersCache.AddOrUpdate(waiter.Id, WaiterFactory.CreateDto(waiter), (key, oldValue) => WaiterFactory.CreateDto(waiter));

    public List<License> GetLicensesCache() =>
        _licensesCache.Values.Select(x => LicenceFactory.Create(x)).ToList();

    public List<Order> GetOrdersCache() =>
        _ordersCache.Values.Select(x => OrderFactory.Create(x)).ToList();

    public List<PaymentType> GetPaymentTypesCache() =>
        _paymentTypes.Values.Select(x => PaymentTypeFactory.Create(x)).ToList();

    public List<Product> GetProductsCache() =>
        _productsCache.Values.Select(x => ProductFactory.Create(x)).ToList();

    public List<Table> GetTablesCache() =>
        _tablesCache.Values.Select(x => TableFactory.Create(x)).ToList();

    public List<Waiter> GetWaitersCache() =>
        _waitersCache.Values.Select(x => WaiterFactory.Create(x)).ToList();

    public bool RemoveLicense(Guid licenseId) => _licensesCache.TryRemove(licenseId, out _);

    public bool RemoveOrder(Guid orderId) => _ordersCache.TryRemove(orderId, out _);

    public bool RemovePaymentType(Guid paymentTypeId) => _paymentTypes.TryRemove(paymentTypeId, out _);

    public bool RemoveProduct(Guid productId) => _productsCache.TryRemove(productId, out _);

    public bool RemoveTable(Guid tableId) => _tablesCache.TryRemove(tableId, out _);

    public bool RemoveWaiter(Guid waiterId) => _waitersCache.TryRemove(waiterId, out _);

    public LicenseOperation GetLicenseOperation(AllCache cache) => new() { Cache = cache };

    public OrderOperation GetOrderOperation(AllCache cache) => new() { Cache = cache };

    public void SetCache()
    {
        DBInteraction DB = default;

        if (_canWork)
        {
            DB = new DBInteraction("localhost", "coby", 3306, "coby", "1234");
            GetTables().ForEach(x => AddTable(TableFactory.Create(x)));
            GetPaymentTypes().ForEach(x => AddPaymentType(PaymentTypeFactory.Create(x)));
            GetWaiters().ForEach(x => AddWaiter(WaiterFactory.Create(x)));
            GetProducts().ForEach(x => AddProduct(ProductFactory.Create(x)));

            _canWork = false;
        }

        List<TableDto> GetTables() =>
            DB.SqlQuery<TableDto>("SELECT * FROM tables");

        List<PaymentTypeDto> GetPaymentTypes() =>
            DB.SqlQuery<PaymentTypeDto>("SELECT * FROM paymentTypes");

        List<WaiterDto> GetWaiters() =>
            DB.SqlQuery<WaiterDto>("SELECT * FROM waiters");

        List<ProductDto> GetProducts() =>
            DB.SqlQuery<ProductDto>("SELECT * FROM `products` WHERE IsItForSale=1");
    }
}