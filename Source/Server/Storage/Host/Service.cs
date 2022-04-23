#nullable enable

using Shared;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Storage.Cache;
using Storage.DataBase;
using Storage.DataBase.Converter;
using Storage.Extention;
using Storage.Operations;
using Storage.Operations.CreateRemove;
using Storage.Operations.GetBy;
using Storage.Operations.OrderOperation;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

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
    private readonly ConcurrentDictionary<Guid, Order> _closeOrders = new();
    private readonly ConcurrentDictionary<Guid, DangerousOperationsDto> _dangerousOperations = new();
    private readonly List<WaiterFace> _waiterFacesCache = new();
    private readonly List<Nomenclature> _nomenclatureCache = new();
    private bool _canWork = true;

    public License AddLicense(License license) =>
        _licensesCache.AddOrUpdate(license.Id, license, (key, oldValue) => license);

    public Order AddOrUpdateOrder(Order source)
    {
        if (_ordersCache.TryGetValue(source.Id, out var orderOnCache))
            return SubmitChanges(orderOnCache, source);
        _ordersCache.TryAdd(source.Id, source);
        HistoryHelper.OrderHistory(source, source.Id, Entities.Order, ActionsEnum.Save);
        return source;

        static T SubmitChanges<T>(T orderTarger, T source)
        {
            foreach (var prop in typeof(T).GetProperties().Where(prop => prop.CanRead && prop.CanWrite))
            {
                var value = prop.GetValue(source, null);
                prop.SetValue(orderTarger, value, null);
            }
            return orderTarger;
        }
    }

    public PaymentType AddOrUpdatePaymentType(PaymentType paymentType) =>
        _paymentTypes.AddOrUpdateDB(paymentType.Id, paymentType, GetDBInteraction(), "paymenttypes");

    public Product AddOrUpdateProduct(Product product) =>
        _productsCache.AddOrUpdateDB(product.Id, product, GetDBInteraction(), "products");

    public Table AddOrUpdateTable(Table table) =>
        _tablesCache.AddOrUpdateDB(table.Id, table, GetDBInteraction(), "tables");

    public Waiter AddOrUpdateWaiter(Waiter waiter) =>
        _waitersCache.AddOrUpdateDB(waiter.Id, waiter, GetDBInteraction(), "waiters");

    public void AddNomenclature(Nomenclature nomenclature) =>
        _nomenclatureCache.AddDB(nomenclature, GetDBInteraction(), "nomenclature");

    public WaiterFace AddOrUpdateWaiterFace(WaiterFace waiterFace) =>
        _waiterFacesCache.AddDB(waiterFace, GetDBInteraction(), "waiterfaces");

    public bool AddDangerousOperations(DangerousOperationsDto dangerousOperations) =>
        _dangerousOperations.TryAdd(dangerousOperations.OperationId, dangerousOperations);

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

    public List<WaiterFace> GetWaiterFacesCache() =>
        _waiterFacesCache.ToList();

    public List<DangerousOperationsDto> GetDangerousOperationsCache() =>
        _dangerousOperations.Values.ToList();

    public List<Order> GetCloseOrders() =>
        _closeOrders.Values.ToList();

    public bool RemoveLicense(Guid licenseId) => _licensesCache.TryRemove(licenseId, out _);

    public bool RemoveOrder(Guid orderId) => _ordersCache.TryRemove(orderId, out _);

    public PaymentType? RemovePaymentType(Guid paymentTypeId) => _paymentTypes.TryRemoveDB(paymentTypeId, GetDBInteraction(), "paymenttypes");

    public Product? RemoveProduct(Guid productId) => _productsCache.TryRemoveDB(productId, GetDBInteraction(), "products");

    public Table? RemoveTable(Guid tableId) => _tablesCache.TryRemoveDB(tableId, GetDBInteraction(), "tables");

    public Waiter? RemoveWaiter(Guid waiterId) => _waitersCache.TryRemoveDB(waiterId, GetDBInteraction(), "waiters");

    public bool RemoveDangerousOperations(Guid dangerousOperationsId) =>
        _dangerousOperations.TryRemove(dangerousOperationsId, out _);

    public List<WaiterFace>? RemoveWaiterFace(Guid waiterFaceId)
    {
        var removeFaces = _waiterFacesCache.Where(x => x.Id.Equals(waiterFaceId)).ToList();
        var db = GetDBInteraction();
        foreach (var face in removeFaces)
        {
            _waiterFacesCache.Remove(face);
            db.ExecuteNonQuery($"DELETE FROM waiterfaces WHERE Id = '{face.Id}'");
        }
        return removeFaces;
    }

    public List<Nomenclature> RemoveNomenclatureByParentAndChildId(Guid parentId, Guid childId)
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

    public List<Nomenclature> RemoveNomenclatureByChildId(Guid childId)
    {
        var removeNomenclature = _nomenclatureCache.Where(x => x.ChildId.Equals(childId)).ToList();
        var db = GetDBInteraction();
        foreach (var item in removeNomenclature)
        {
            _nomenclatureCache.Remove(item);
            db.ExecuteNonQuery($"DELETE FROM nomenclature WHERE ChildId = '{item.ChildId}'");
        }
        return removeNomenclature;
    }

    public LicenseOperation GetLicenseOperation(AllCache cache) => new() { Cache = cache };

    public OrderOperation GetOrderOperation(AllCache cache) => new() { Cache = cache };

    public WaiterOperation GetWaiterOperation(AllCache cache) => new() { Cache = cache };

    public DangerousOperation GetDangerousOperation(AllCache cache) => new() { Cache = cache };

    public Creater GetCreater(AllCache cache) => new() { Cache = cache };

    public Remover GetRemover(AllCache cache) => new() { Cache = cache };

    public Waiter ChangeWaiterStatus(Guid waiterId, WaiterSessionStatus status)
    {
        _waitersCache.TryGetValue(waiterId, out Waiter waiter);
        waiter.Status = status;
        return waiter;
    }

    public async void SetCache()
    {
        DBInteraction db = default;

        if (_canWork)
        {
            Log.Info("Loading database table on server cache...");

            db = GetDBInteraction();
            GetTables().ForEach(x => _tablesCache.TryAdd(x.Id, x));
            GetPaymentTypes().ForEach(x => _paymentTypes.TryAdd(x.Id, PaymentTypeConverter.Converter(x)));
            GetWaiters().ForEach(x => _waitersCache.TryAdd(x.Id, WaiterConverter.Converter(x)));
            GetWaiterFaces().ForEach(x => _waiterFacesCache.Add(x));
            GetProducts().ForEach(x => _productsCache.TryAdd(x.Id, x));
            GetNomenclature().ForEach(x => _nomenclatureCache.Add(x));
            Task.Run(() => LoadCloseOrders().ConfigureAwait(false));
            Task.Run(() => LoadDangerousOperation().ConfigureAwait(false));

            _canWork = false;
        }

        List<Table> GetTables() =>
            db.SqlQuery<Table>("SELECT * FROM tables");

        List<PaymentTypeDB> GetPaymentTypes() =>
            db.SqlQuery<PaymentTypeDB>("SELECT * FROM paymentTypes");

        List<WaiterDB> GetWaiters() =>
            db.SqlQuery<WaiterDB>("SELECT * FROM waiters");

        List<WaiterFace> GetWaiterFaces() =>
            db.SqlQuery<WaiterFace>("SELECT * FROM waiterfaces");

        List<Product> GetProducts() =>
            db.SqlQuery<Product>("SELECT * FROM products");

        List<Nomenclature> GetNomenclature() =>
            db.SqlQuery<Nomenclature>("SELECT * FROM nomenclature");

        Task LoadCloseOrders()
        {
            _licensesCache.TryAdd(Guid.Empty, new(Guid.Empty));

            List<OrderDB> closeOrders = db.SqlQuery<OrderDB>("SELECT * FROM orders");
            List<GuestDB> guests = db.SqlQuery<GuestDB>("SELECT * FROM ordersguests");
            List<PaymentDB> payments = db.SqlQuery<PaymentDB>("SELECT * FROM orderspayments");
            List<ProductDB> products = db.SqlQuery<ProductDB>("SELECT * FROM ordersproducts");
            List<History> histories = db.SqlQuery<History>("SELECT * FROM history");
            var cache = new AllCache(this);
            var getBy = new GetByCache(cache);
            var orderOperation = GetOrderOperation(cache);

            foreach (var closeOrder in closeOrders)
            {
                var table = getBy.Table.GetTableById(closeOrder.TableId);
                var waiter = getBy.Waiter.GetWaiterById(closeOrder.WaiterId);
                var orderGuests = guests.Where(x => x.OrderId.Equals(closeOrder.Id));
                var orderProduts = products.Where(x => x.OrderId.Equals(closeOrder.Id));
                var orderPayments = payments.Where(x => x.OrderId.Equals(closeOrder.Id));

                var order = new Order(closeOrder.Id, table, waiter, OrderStatus.Closed, closeOrder.GetStartTime(), closeOrder.GetEndTime());
                var guestOperations = orderOperation.GetGuestOperations(order);
                var productOperation = orderOperation.GetProductOperation(order);
                var paymentOperation = orderOperation.GetPaymentOperations(order);

                foreach (var guest in orderGuests)
                {
                    guestOperations.AddGuestOnOrder(GetAdminCredentials(), guest.GuestId, guest.Name);
                    foreach (var product in orderProduts.Where(x => x.GuestId.Equals(guest.GuestId)))
                        productOperation.AddProductOnOrder(GetAdminCredentials(), guest.GuestId, product.ProductId);
                }

                foreach (var payment in orderPayments)
                    paymentOperation.AddPaymentOnOrder(GetAdminCredentials(), payment.PaymentId, payment.Sum);

                order.OrderHistories.Clear();
                foreach (var history in histories.Where(x => x.OrderId.Equals(order.Id)))
                    order.OrderHistories.TryAdd(history.HistoryId, history);

                _closeOrders.TryAdd(order.Id, order);
            }
            _licensesCache.TryRemove(Guid.Empty, out _);
            return Task.CompletedTask;
        }

        Task LoadDangerousOperation()
        {
            db.SqlQuery<DangerousOperationDB>("SELECT * FROM dangerousoperations")
              .ForEach(x => _dangerousOperations.TryAdd(x.OperationId, DangerousOperationConverter.Converter(x)));
            return Task.CompletedTask;
        }

        Credentials GetAdminCredentials() =>
            new(_licensesCache.Values.First(x => x.Id.Equals(Guid.Empty)).Id);
    }

    public async Task<Request> CloseCafeShift(Credentials credentials, CashRegister cashRegister)
    {
        var waiter = GetWaitersCache().First(x => x.Id.Equals(credentials.WaiterId));
        if (waiter.PermissionStatus is PermissionStatus.Waiter)
            return new(waiter.Id, RequestStatus.DeniedPermission, "Недостаточно прав.");

        if (GetOrdersCache().Where(x => x.Status is OrderStatus.Closed).Count() <= 0)
            return new(waiter.Id, RequestStatus.EntityNotFound, "Количество закрытых заказов должно быть больше 0.");

        if (GetOrdersCache().Where(x => x.Status is OrderStatus.New).Count() > 0)
            return new(waiter.Id, RequestStatus.EntityNotFound, "Все заказы должны быть закрыты.");

        var remainderCasheOnCache = _ordersCache.Values.Sum(x => x.Sum)
                                    - _ordersCache.Values.SelectMany(x => x.GetPayments())
                                                         .Where(x => x.PaymentEnum is not PaymentEnum.Cash)
                                                         .Sum(x => x.Sum);
        if (cashRegister.CashOnRegister.Equals(remainderCasheOnCache) is false)
            AddDangerousOperations(new(waiter.Id,
                                       $"The entered balance does not correspond to the actual balance in the cash register. " +
                                       $"Waiter [{waiter.Name}]. " +
                                       $"Entered cash balance: {cashRegister.CashOnRegister}"));

        Log.Info("Closing cafe shift...");
        var db = GetDBInteraction();
        LoadClosedOrderOnDB();
        LoadDangerousOperationOnDB();
        CloseAllWaiterShift();
        _ordersCache.Clear();

        return new(waiter.Id, RequestStatus.OK, default);

        void LoadClosedOrderOnDB()
        {
            foreach (var order in _ordersCache.Values.Where(x => x.Status is OrderStatus.Closed))
            {
                var orderDB = new OrderDB(order.Id, order.Table.Id, order.Waiter.Id, (decimal)order.Sum, order.StartTime, (DateTime)order.EndTime);
                db.ExecuteNonQuery(SQLString.GetInsertSqlString(orderDB, "orders"));
                foreach (var payment in order.GetPayments())
                {
                    var paymentDB = new PaymentDB(order.Id, payment.Id, payment.Sum);
                    db.ExecuteNonQuery(SQLString.GetInsertSqlString(paymentDB, "orderspayments"));
                }
                foreach (var guest in order.GetGuests())
                {
                    var guestDB = new GuestDB(order.Id, guest.Id, guest.Name);
                    db.ExecuteNonQuery(SQLString.GetInsertSqlString(guestDB, "ordersguests"));
                    foreach (var product in guest.GetProducts())
                    {
                        var productDB = new ProductDB(order.Id, guest.Id, product.Id);
                        db.ExecuteNonQuery(SQLString.GetInsertSqlString(productDB, "ordersproducts"));
                    }
                }

                foreach (var history in order.GetHistories())
                    db.ExecuteNonQuery(SQLString.GetInsertSqlString(history, "history"));

                _closeOrders.TryAdd(order.Id, order);
            }
        }

        void LoadDangerousOperationOnDB()
        {
            foreach (var dangerousOperation in _dangerousOperations.Values.Where(x => x.DangerousOperationEnum is DangerousOperationEnum.NotAdded))
            {
                var dangerousOperationDB = new DangerousOperationDB(dangerousOperation);
                db.ExecuteNonQuery(SQLString.GetInsertSqlString(dangerousOperationDB, "dangerousoperations"));
                dangerousOperation.SetDangerousOperationEnum(DangerousOperationEnum.AddedOnDB);
            }
        }

        void CloseAllWaiterShift()
        {
            var cache = new AllCache(this);
            var waiterOperation = GetWaiterOperation(cache);

            foreach (var waiter in _waitersCache.Values)
                waiterOperation.ClosePersonalShift(waiter.Id);
        }
    }

    private DBInteraction GetDBInteraction() =>
        new("localhost", "coby", 3306, "coby", "1234");
}