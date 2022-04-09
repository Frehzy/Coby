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

    public PaymentType CreatePaymentType(string name) =>
        Helper.PaymentTypeByName(Cache, name, out PaymentType paymentTypeOnCache) is not null
        ? throw new EntityAlreadyExistsException(paymentTypeOnCache.Id)
        : Cache.PaymentTypesCache.AddOrUpdatePaymentType(new PaymentType(Guid.NewGuid(), name));

    public Product CreateProduct(string productName, decimal price, bool isItForSale) =>
        Helper.ProductByName(Cache, productName, out Product productOnCache) is not null
        ? throw new EntityAlreadyExistsException(productOnCache.Id)
        : Cache.ProductsCache.AddOrUpdateProduct(new Product(Guid.NewGuid(), productName, price, isItForSale));

    public Table CreateTable(int tableNumber) =>
        Helper.TableByNumber(Cache, tableNumber, out Table tableOnCache) is not null
            ? throw new EntityAlreadyExistsException(tableOnCache.Id)
            : Cache.TablesCache.AddOrUpdateTable(new Table(Guid.NewGuid(), tableNumber));

    public Waiter CreateWaiter(string name, string password, PermissionStatus permissionStatus) =>
        Helper.WaiterByPassword(Cache, password, out Waiter waiterOnCache) is not null
            ? throw new EntityAlreadyExistsException(waiterOnCache.Id)
            : Cache.WaitersCache.AddOrUpdateWaiter(new Waiter(Guid.NewGuid(), name, password, permissionStatus, WaiterSessionStatus.Closed));

    public WaiterFace AddWaiterFacesById(Guid waiterFaceId, Image face) =>
        Helper.WaiterFaceById(Cache, waiterFaceId, out List<WaiterFace> waiterFaceOnCache) is null
            ? throw new EntityAlreadyExistsException(waiterFaceOnCache.Select(x => x.Id).First())
            : Cache.WaiterFaceCache.AddOrUpdateWaiterFace(new(waiterFaceId, face));

    public DangerousOperationsDto AddDangerousOperations(Guid waiterId, string message) =>
        Cache.DangerousOperationCache.AddDangerousOperations(new(waiterId, message));
}