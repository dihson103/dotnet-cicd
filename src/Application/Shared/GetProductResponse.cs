using Domain.Entities;

namespace Application.Shared;

public class GetProductResponse 
{
    private GetProductResponse() { }
    public Guid Id { get; private set; }
    public string ProductName { get; private set; }
    public decimal ProductPrice { get; private set; }
    public int ProductQuanity { get; private set; }
    public string CreateBy { get; private set; }
    public DateTime CreateDate { get; private set; }

    public static GetProductResponse Create(Product product)
    {
        return new GetProductResponse
        {
            Id = product.Id,
            ProductName = product.ProductName,
            ProductPrice = product.ProductPrice,
            ProductQuanity = product.ProductQuanity,
            CreateBy = product.CreatedBy,
            CreateDate = product.CreatedDate
        };
    }
}
