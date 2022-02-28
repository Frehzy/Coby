using Shared.Dto.Enities;

namespace Storage.Operations.ProductOperation;

public interface IProductOperation
{
    Product CreateProduct(string productName, decimal price, bool isItForSale);
}