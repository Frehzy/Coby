#nullable enable

using Shared.Dto.Enities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Storage.Host;

[ServiceContract]
public interface IProductCache
{
    [OperationContract]
    List<Product> GetProductsCache();

    [OperationContract]
    Product AddOrUpdateProduct(Product product);

    [OperationContract]
    Product? RemoveProduct(Guid productId);

}