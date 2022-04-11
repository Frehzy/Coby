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
        return nomenclature;
    }

    public PaymentType CreatePaymentType(string name, PaymentEnum paymentEnum) =>
        Helper.PaymentTypeByName(Cache, name, out PaymentType paymentTypeOnCache) is null
        ? Cache.PaymentTypesCache.AddOrUpdatePaymentType(new PaymentType(Guid.NewGuid(), name, paymentEnum))
        : throw new EntityAlreadyExistsException(paymentTypeOnCache.Id);

    public Product CreateProduct(string productName, decimal price, bool isItForSale) =>
        Helper.ProductByName(Cache, productName, out Product productOnCache) is null
        ? Cache.ProductsCache.AddOrUpdateProduct(new Product(Guid.NewGuid(), productName, price, isItForSale))
        : throw new EntityAlreadyExistsException(productOnCache.Id);

    public Table CreateTable(int tableNumber) =>
        Helper.TableByNumber(Cache, tableNumber, out Table tableOnCache) is null
            ? Cache.TablesCache.AddOrUpdateTable(new Table(Guid.NewGuid(), tableNumber))
            : throw new EntityAlreadyExistsException(tableOnCache.Id);

    public Waiter CreateWaiter(string name, string password, PermissionStatus permissionStatus) =>
        Helper.WaiterByPassword(Cache, password, out Waiter waiterOnCache) is null
            ? Cache.WaitersCache.AddOrUpdateWaiter(new Waiter(Guid.NewGuid(), name, password, permissionStatus, WaiterSessionStatus.Closed))
            : throw new EntityAlreadyExistsException(waiterOnCache.Id);

    public WaiterFace AddWaiterFacesById(Guid waiterFaceId, Image face) =>
        Helper.WaiterFaceById(Cache, waiterFaceId, out List<WaiterFace> waiterFaceOnCache) is not null
            ? Cache.WaiterFaceCache.AddOrUpdateWaiterFace(new(waiterFaceId, face))
            : throw new EntityAlreadyExistsException(waiterFaceOnCache.Select(x => x.Id).First());
}