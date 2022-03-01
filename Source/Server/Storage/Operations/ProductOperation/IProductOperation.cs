using Shared.Dto.Enities;
using System;

namespace Storage.Operations.ProductOperation;

public interface IProductOperation
{
    Product CreateProduct(string productName, decimal price, bool isItForSale);

    Product GetProductById(Guid productId);

    Product AddProductOnOrder(Guid orderId, Guid guestId, Guid productId);

    void RemoveProductOnOrder(Guid orderId, Guid guestId, Guid productId, int rank);
}