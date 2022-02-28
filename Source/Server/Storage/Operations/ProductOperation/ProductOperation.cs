using Shared.Dto.Enities;
using Shared.Dto.Exceptions;
using Storage.Cache;
using System;
using System.Linq;

namespace Storage.Operations.ProductOperation;

public class ProductOperation : IProductOperation
{
    public AllCache Cache { get; set; }

    public Product CreateProduct(string productName, decimal price, bool isItForSale)
    {
        if (Cache is null)
            throw new ArgumentNullException("Cache cannot be null.");

        var productOnCache = Cache.ProductsCache.GetProductsCache().FirstOrDefault(x => x.ProductName.Equals(productName));
        if (productOnCache is not null)
            throw new EntityAlreadyExistsException(productOnCache.Id);

        return Cache.ProductsCache.AddProduct(new Product(Guid.NewGuid(), productName, price, isItForSale));
    }
}