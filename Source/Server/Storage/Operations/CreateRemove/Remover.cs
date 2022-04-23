using Shared;
using Shared.Dto.Enities;
using Storage.Cache;
using Storage.DataBase;
using System;
using System.Collections.Generic;

namespace Storage.Operations.CreateRemove;

public class Remover
{
    public AllCache Cache { get; set; }

    public List<Nomenclature> RemoveNomenclatureByChildId(Guid childId)
    {
        Log.Info($"{nameof(Nomenclature)} remove. Guid (child): {childId}");
        return Cache.NomenclatureCache.RemoveNomenclatureByChildId(childId);
    }

    public List<Nomenclature> RemoveNomenclatureByParentAndChildId(Guid parentId, Guid childId)
    {
        Log.Info($"{nameof(Nomenclature)} remove. Guid (parent): {parentId}, Guid (child): {childId}");
        return Cache.NomenclatureCache.RemoveNomenclatureByParentAndChildId(parentId, childId);
    }

    public PaymentType? RemovePaymentTypeById(Guid paymentTypeId)
    {
        Log.Info($"{nameof(PaymentType)} remove. Guid: {paymentTypeId}");
        return Cache.PaymentTypesCache.RemovePaymentType(paymentTypeId);
    }

    public Product? RemoveProductById(Guid productId)
    {
        Log.Info($"{nameof(Product)} remove. Guid: {productId}");
        return Cache.ProductsCache.RemoveProduct(productId);
    }

    public Table? RemoveTableById(Guid tableId)
    {
        Log.Info($"{nameof(Table)} remove. Guid: {tableId}");
        return Cache.TablesCache.RemoveTable(tableId);
    }

    public Waiter? RemoveWaiterById(Guid waiterId)
    {
        Log.Info($"{nameof(Waiter)} remove. Guid: {waiterId}");
        return Cache.WaitersCache.RemoveWaiter(waiterId);
    }

    public List<WaiterFace> RemoveWaiterFacesById(Guid waiterId)
    {
        Log.Info($"{nameof(WaiterFace)} remove. Guid: {waiterId}");
        return Cache.WaiterFaceCache.RemoveWaiterFace(waiterId);
    }
}