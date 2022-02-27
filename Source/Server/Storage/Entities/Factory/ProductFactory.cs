using Shared.Dto.Enities;
using Storage.Entities.Implementation;

namespace Storage.Entities.Factory;

internal static class ProductFactory
{
    public static ProductDto CreateDto(Product product) =>
        new()
        {
            Id = product.Id,
            Price = product.Price,
            ProductName = product.ProductName,
            IsItForSale = product.IsItForSale
        };

    public static Product Create(ProductDto productDto) =>
        new(productDto.Id, productDto.ProductName, productDto.Price, productDto.IsItForSale);
}