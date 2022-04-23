using Shared;
using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using Storage.DataBase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Storage.Operations.CreateRemove;

public class Creater
{
    public AllCache Cache { get; set; }

    public Nomenclature CreateNomenclature(Guid parentId, Guid childId, decimal amount)
    {
        if (Helper.NomenclatureByParentAndChildId(Cache, parentId, childId, out Nomenclature nomenclatureOnCache) is not null)
            throw new EntityAlreadyExistsException(new List<Guid>() { nomenclatureOnCache.ParentId, nomenclatureOnCache.ChildId });

        var nomenclature = new Nomenclature(parentId, childId, amount);
        Cache.NomenclatureCache.AddNomenclature(nomenclature);
        Log.Info($"{nameof(Nomenclature)} create. {Log.SerializeInstance(nomenclature)}");
        return nomenclature;
    }

    public PaymentType CreatePaymentType(string name, PaymentEnum paymentEnum)
    {
        if (Helper.PaymentTypeByName(Cache, name, out PaymentType paymentTypeOnCache) is not null)
            throw new EntityAlreadyExistsException(paymentTypeOnCache.Id);

        var paymentType = new PaymentType(Guid.NewGuid(), name, paymentEnum);
        Log.Info($"{nameof(PaymentType)} create. {Log.SerializeInstance(paymentType)}");
        return Cache.PaymentTypesCache.AddOrUpdatePaymentType(paymentType);
    }

    public Product CreateProduct(string productName, decimal price, bool isItForSale)
    {
        if (Helper.ProductByName(Cache, productName, out Product productOnCache) is not null)
            throw new EntityAlreadyExistsException(productOnCache.Id);

        var product = new Product(Guid.NewGuid(), productName, price, isItForSale);
        Log.Info($"{nameof(Product)} create. {Log.SerializeInstance(product)}");
        return Cache.ProductsCache.AddOrUpdateProduct(product);
    }

    public Table CreateTable(int tableNumber)
    {
        if (Helper.TableByNumber(Cache, tableNumber, out Table tableOnCache) is not null)
            throw new EntityAlreadyExistsException(tableOnCache.Id);

        var table = new Table(Guid.NewGuid(), tableNumber);
        Log.Info($"{nameof(Table)} create. {Log.SerializeInstance(table)}");
        return Cache.TablesCache.AddOrUpdateTable(table);
    }

    public Waiter CreateWaiter(string name, string password, PermissionStatus permissionStatus)
    {
        if (Helper.WaiterByPassword(Cache, password, out Waiter waiterOnCache) is not null)
            throw new EntityAlreadyExistsException(waiterOnCache.Id);

        var waiter = new Waiter(Guid.NewGuid(), name, password, permissionStatus, WaiterSessionStatus.Closed);
        Log.Info($"{nameof(Waiter)} create. {Log.SerializeInstance(waiter)}");
        return Cache.WaitersCache.AddOrUpdateWaiter(waiter);
    }

    public WaiterFace AddWaiterFacesById(Guid waiterFaceId, Image face)
    {
        if (Helper.WaiterFaceById(Cache, waiterFaceId, out List<WaiterFace> waiterFaceOnCache) is null)
            throw new EntityAlreadyExistsException(waiterFaceOnCache.Select(x => x.Id).First());

        var waiterFace = new WaiterFace(waiterFaceId, face);
        Log.Info($"{nameof(WaiterFace)} create. {Log.SerializeInstance(waiterFace)}");
        return Cache.WaiterFaceCache.AddOrUpdateWaiterFace(waiterFace);
    }
}