using Shared.Dto;
using Storage.Entities.Interface;

namespace Storage.Entities.ConverterToDto;

internal class ToProductDto
{
    public IProduct Product { get; }

    public ToProductDto(IProduct product) =>
        Product = product;

    public ProductDto Convert() =>
        new(Product.Id, Product.ProductName, Product.Price);
}