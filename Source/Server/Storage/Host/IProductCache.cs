using Shared.Dto.Enities;
using Storage.Entities.Implementation;
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
    ProductDto AddProduct(Product product);

    [OperationContract]
    bool RemoveProduct(Guid productId);

}