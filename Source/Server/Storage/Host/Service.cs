#nullable enable

using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Storage.Cache;
using Storage.DataBase;
using Storage.Extention;
using Storage.Operations.GuestOperation;
using Storage.Operations.LicenseOperation;
using Storage.Operations.NomenclatureOperation;
using Storage.Operations.OrderOperation;
using Storage.Operations.PaymentOperation;
using Storage.Operations.ProductOperation;
using Storage.Operations.TableOperation;
using Storage.Operations.WaiterOperation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Storage.Host;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Service : IService
{
    private readonly ConcurrentDictionary<Guid, License> _licensesCache = new();
    private readonly ConcurrentDictionary<Guid, Order> _ordersCache = new();
    private readonly ConcurrentDictionary<Guid, PaymentType> _paymentTypes = new();
    private readonly ConcurrentDictionary<Guid, Product> _productsCache = new();
    private readonly ConcurrentDictionary<Guid, Table> _tablesCache = new();
    private readonly ConcurrentDictionary<Guid, Waiter> _waitersCache = new();
    private readonly List<Nomenclature> _nomenclatureCache = new();
    private bool _canWork = true;

    public License AddLicense(License license) =>
        _licensesCache.AddOrUpdate(license.Id, license, (key, oldValue) => license);

    public Order AddOrder(Order order) =>
        _ordersCache.AddOrUpdate(order.Id, order, (key, oldValue) => order);

    public PaymentType AddPaymentType(PaymentType paymentType) =>
        _paymentTypes.AddOrUpdateDB(paymentType.Id, paymentType, GetDBInteraction(), "paymenttypes");

    public Product AddProduct(Product product) =>
        _productsCache.AddOrUpdateDB(product.Id, product, GetDBInteraction(), "products");

    public Table AddTable(Table table) =>
        _tablesCache.AddOrUpdateDB(table.Id, table, GetDBInteraction(), "tables");

    public Waiter AddWaiter(Waiter waiter) =>
        _waitersCache.AddOrUpdateDB(waiter.Id, waiter, GetDBInteraction(), "waiters");

    public void AddNomenclature(Nomenclature nomenclature) =>
        _nomenclatureCache.AddDB(nomenclature, GetDBInteraction(), "nomenclature");

    public List<License> GetLicensesCache() =>
        _licensesCache.Values.ToList();

    public List<Order> GetOrdersCache() =>
        _ordersCache.Values.ToList();

    public List<PaymentType> GetPaymentTypesCache() =>
        _paymentTypes.Values.ToList();

    public List<Product> GetProductsCache() =>
        _productsCache.Values.ToList();

    public List<Table> GetTablesCache() =>
        _tablesCache.Values.ToList();

    public List<Waiter> GetWaitersCache() =>
        _waitersCache.Values.ToList();

    public List<Nomenclature> GetNomenclaturesCache() =>
        _nomenclatureCache.ToList();

    public bool RemoveLicense(Guid licenseId) => _licensesCache.TryRemove(licenseId, out _);

    public bool RemoveOrder(Guid orderId) => _ordersCache.TryRemove(orderId, out _);

    public PaymentType? RemovePaymentType(Guid paymentTypeId) => _paymentTypes.TryRemoveDB(paymentTypeId, GetDBInteraction(), "paymenttypes");

    public Product? RemoveProduct(Guid productId) => _productsCache.TryRemoveDB(productId, GetDBInteraction(), "products");

    public Table? RemoveTable(Guid tableId) => _tablesCache.TryRemoveDB(tableId, GetDBInteraction(), "tables");

    public Waiter? RemoveWaiter(Guid waiterId) => _waitersCache.TryRemoveDB(waiterId, GetDBInteraction(), "waiters");

    public List<Nomenclature> RemoveNomenclature(Guid parentId, Guid childId)
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

    public TableOperation GetTableOperation(AllCache cache) => new() { Cache = cache };

    public ProductOperation GetProductOperation(AllCache cache) => new() { Cache = cache };

    public WaiterOperation GetWaiterOperation(AllCache cache) => new() { Cache = cache };

    public PaymentOperation GetPaymentOperation(AllCache cache) => new() { Cache = cache };

    public NomenclatureOperation GetNomenclatureOperation(AllCache cache) => new() { Cache = cache };

    public GuestOperation GetGuestOperation(AllCache cache) => new() { Cache = cache };

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

        List<Table> GetTables() =>
            DB.SqlQuery<Table>("SELECT * FROM tables");

        List<PaymentType> GetPaymentTypes() =>
            DB.SqlQuery<PaymentType>("SELECT * FROM paymentTypes");

        List<Waiter> GetWaiters() =>
            DB.SqlQuery<Waiter>("SELECT * FROM waiters");

        List<Product> GetProducts() =>
            DB.SqlQuery<Product>("SELECT * FROM products");

        List<Nomenclature> GetNomenclature() =>
            DB.SqlQuery<Nomenclature>("SELECT * FROM nomenclature");
    }

    public void CloseCafeShift()
    {
        LoadClosedOrderOnDB();
        CloseAllWaiterShift();
        _ordersCache.Clear();
        _licensesCache.Clear();

        void LoadClosedOrderOnDB()
        {
            var db = GetDBInteraction();
            foreach (var order in _ordersCache.Values.Where(x => x.OrderStatus is OrderStatus.Closed))
            {
                var orderDB = new OrderDB(order.Id, order.Table.Id, order.Waiter.Id, (decimal)order.Sum, order.StartTime, DateTime.Now);
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

        void CloseAllWaiterShift()
        {
            foreach (var waiter in _waitersCache.Values)
                waiter.Status = WaiterSessionStatus.Closed;
        }
    }

    private DBInteraction GetDBInteraction() =>
        new("localhost", "coby", 3306, "coby", "1234");
}