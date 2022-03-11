using Shared.Dto.Enities;

namespace Office.Entities;

internal class GroupProduct
{
    public Product Product { get; }

    public decimal Sum { get; }

    public int Count { get; }

    public GroupProduct(Product product, decimal sum, int count)
    {
        Product = product;
        Sum = sum;
        Count = count;
    }
}