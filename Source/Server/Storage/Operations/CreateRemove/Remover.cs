#nullable enable

using Shared.Dto.Enities;
using Storage.Cache;
using System;
using System.Collections.Generic;

namespace Storage.Operations.CreateRemove;

public class Remover
{
    public AllCache Cache { get; set; }

    public List<Nomenclature> RemoveNomenclatureByChildId(Guid childId) =>
        Cache.NomenclatureCache.RemoveNomenclatureByChildId(childId);

    public List<Nomenclature> RemoveNomenclatureByParentAndChildId(Guid parentId, Guid childId) =>
        Cache.NomenclatureCache.RemoveNomenclatureByParentAndChildId(parentId, childId);

    public PaymentType? RemovePaymentTypeById(Guid paymentTypeId) =>
        Cache.PaymentTypesCache.RemovePaymentType(paymentTypeId);

    public Product? RemoveProductById(Guid productId) =>
        Cache.ProductsCache.RemoveProduct(productId);

    public Table? RemoveTableById(Guid tableId) =>
        Cache.TablesCache.RemoveTable(tableId);

    public Waiter? RemoveWaiterById(Guid waiterId) =>
        Cache.WaitersCache.RemoveWaiter(waiterId);
}