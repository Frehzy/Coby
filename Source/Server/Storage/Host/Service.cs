#nullable enable

using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Storage.Cache;
using Storage.DataBase;
using Storage.Entities.Factory;
using Storage.Entities.Implementation;
using Storage.Extention;
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
    private readonly List<NomenclatureDto> _nomenclatureCache = new();
    private bool _canWork = true;

    public LicenseDto AddLicense(License license) =>
        _licensesCache.AddOrUpdate(license.Id, LicenceFactory.CreateDto(license), (key, oldValue) => LicenceFactory.CreateDto(license));

    public OrderDto AddOrder(Order order) =>
        _ordersCache.AddOrUpdate(order.Id, OrderFactory.CreateDto(order), (key, oldValue) => OrderFactory.CreateDto(order));

    public PaymentTypeDto AddPaymentType(PaymentType paymentType) =>
        _paymentTypes.AddOrUpdateDB(paymentType.Id, PaymentTypeFactory.CreateDto(paymentType), GetDBInteraction(), "paymenttypes");

    public ProductDto AddProduct(Product product) =>
        _productsCache.AddOrUpdateDB(product.Id, ProductFactory.CreateDto(product), GetDBInteraction(), "products");

    public TableDto AddTable(Table table) =>
        _tablesCache.AddOrUpdateDB(table.Id, TableFactory.CreateDto(table), GetDBInteraction(), "tables");

    public WaiterDto AddWaiter(Waiter waiter) =>
        _waitersCache.AddOrUpdateDB(waiter.Id, WaiterFactory.CreateDto(waiter), GetDBInteraction(), "waiters");

    public void AddNomenclature(Nomenclature nomenclature) =>
        _nomenclatureCache.AddDB(NomenclatureFactory.CreateDto(nomenclature), GetDBInteraction(), "nomenclature");

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

    public List<Nomenclature> GetNomenclaturesCache() =>
        _nomenclatureCache.Select(x => NomenclatureFactory.Create(x)).ToList();

    public bool RemoveLicense(Guid licenseId) => _licensesCache.TryRemove(licenseId, out _);

    public bool RemoveOrder(Guid orderId) => _ordersCache.TryRemove(orderId, out _);

    public PaymentTypeDto? RemovePaymentType(Guid paymentTypeId) => _paymentTypes.TryRemoveDB(paymentTypeId, GetDBInteraction(), "paymenttypes");

    public ProductDto? RemoveProduct(Guid productId) => _productsCache.TryRemoveDB(productId, GetDBInteraction(), "products");

    public TableDto? RemoveTable(Guid tableId) => _tablesCache.TryRemoveDB(tableId, GetDBInteraction(), "tables");

    public WaiterDto? RemoveWaiter(Guid waiterId) => _waitersCache.TryRemoveDB(waiterId, GetDBInteraction(), "waiters");

    public List<NomenclatureDto> RemoveNomenclature(Guid parentId, Guid childId)
    {
        var removeNomenclature = _nomenclatureCache.Where(x => x.ParentId.Equals(parentId) && x.ChildId.Equals(childId)).ToList();
        var db = GetDBInteraction();
        foreach (var item in removeNomenclature)
        {
            _nomenclatureCache.Remove(item);
            db.ExecuteNonQuery($"DELETE FROM nomenclature WHERE ParentId = '{item.ParentId}' AND ChildId = '{item.ChildId}'");
        }
        return removeNomenclature;
    }

    public LicenseOperation GetLicenseOperation(AllCache cache) => new() { Cache = cache };

    public OrderOperation GetOrderOperation(AllCache cache) => new() { Cache = cache };

    public void SetCache()
    {
        DBInteraction DB = default;

        if (_canWork)
        {
            DB = GetDBInteraction();
            GetTables().ForEach(x => _tablesCache.TryAdd(x.Id, x));
            GetPaymentTypes().ForEach(x => _paymentTypes.TryAdd(x.Id, x));
            GetWaiters().ForEach(x => _waitersCache.TryAdd(x.Id, x));
            GetProducts().ForEach(x => _productsCache.TryAdd(x.Id, x));
            GetNomenclature().ForEach(x => _nomenclatureCache.Add(x));

            _canWork = false;
        }

        List<TableDto> GetTables() =>
            DB.SqlQuery<TableDto>("SELECT * FROM tables");

        List<PaymentTypeDto> GetPaymentTypes() =>
            DB.SqlQuery<PaymentTypeDto>("SELECT * FROM paymentTypes");

        List<WaiterDto> GetWaiters() =>
            DB.SqlQuery<WaiterDto>("SELECT * FROM waiters");

        List<ProductDto> GetProducts() =>
            DB.SqlQuery<ProductDto>("SELECT * FROM products");

        List<NomenclatureDto> GetNomenclature() =>
            DB.SqlQuery<NomenclatureDto>("SELECT * FROM nomenclature");
    }

    public void LoadClosedOrderOnDB()
    {
        var db = GetDBInteraction();
        foreach (var order in _ordersCache.Values.Where(x => x.OrderStatus is OrderStatus.Closed))
        {
            var orderDB = new OrderDB(order.Id, order.Table.Id, order.Waiter.Id, order.Sum, order.StartTime, DateTime.Now);
            db.ExecuteNonQuery(SQLString.GetInsertSqlString(orderDB, "orders"));
            foreach (var payment in order.Payment.Values)
            {
                var paymentDB = new PaymentDB(order.Id, payment.Id, payment.Sum);
                db.ExecuteNonQuery(SQLString.GetInsertSqlString(paymentDB, "orderspayments"));
            }
            foreach (var guest in order.Guests.Values)
            {
                var guestDB = new GuestDB(order.Id, guest.Id, guest.Name);
                db.ExecuteNonQuery(SQLString.GetInsertSqlString(guestDB, "ordersguests"));
                foreach (var product in guest.Products.Values)
                {
                    var productDB = new ProductDB(order.Id, product.Id);
                    db.ExecuteNonQuery(SQLString.GetInsertSqlString(productDB, "ordersproducts"));
                }
            }
        }
    }

    private DBInteraction GetDBInteraction() =>
        new("localhost", "coby", 3306, "coby", "1234");
}