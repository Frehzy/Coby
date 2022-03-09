using Shared.Dto.Enities;
using Shared.Dto.Enums;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Collections.Generic;

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
        return nomenclature;
    }

    public PaymentType CreatePaymentType(string name)
    {
        if (Helper.PaymentTypeByName(Cache, name, out PaymentType paymentTypeOnCache) is not null)
            throw new EntityAlreadyExistsException(paymentTypeOnCache.Id);

        return Cache.PaymentTypesCache.AddPaymentType(new PaymentType(Guid.NewGuid(), name));
    }

    public Product CreateProduct(string productName, decimal price, bool isItForSale) =>
        Helper.ProductByName(Cache, productName, out Product productOnCache) is not null
        ? throw new EntityAlreadyExistsException(productOnCache.Id)
        : Cache.ProductsCache.AddProduct(new Product(Guid.NewGuid(), productName, price, isItForSale));

    public Table CreateTable(int tableNumber) =>
        Helper.TableByNumber(Cache, tableNumber, out Table tableOnCache) is not null
            ? throw new EntityAlreadyExistsException(tableOnCache.Id)
            : Cache.TablesCache.AddTable(new Table(Guid.NewGuid(), tableNumber));

    public Waiter CreateWaiter(string name, string password, PermissionStatus permissionStatus) =>
        Helper.WaiterByPassword(Cache, password, out Waiter waiterOnCache) is not null
            ? throw new EntityAlreadyExistsException(waiterOnCache.Id)
            : Cache.WaitersCache.AddWaiter(new Waiter(Guid.NewGuid(), name, password, permissionStatus, WaiterSessionStatus.Closed));
}