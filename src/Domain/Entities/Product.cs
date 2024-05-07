using Domain.Abstractions;

namespace Domain.Entities;

public class Product : EntityAuditBase<Guid>
{
    private Product() { }
    public string ProductName { get; private set; }
    public decimal ProductPrice { get; private set; }
    public int ProductQuanity { get; private set; }

    public static Product Create(Guid id, string productName, decimal productPrice, int productQuanity)
    {
        return new Product
        {
            Id = id,
            ProductName = productName,
            ProductPrice = productPrice,
            ProductQuanity = productQuanity,
            CreatedBy = "Nguyen Dinh Son",
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            UpdatedBy = "Nguyen Dinh Son"
        };
    }

    public void Update(string productName, decimal productPrice, int productQuanity)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        ProductQuanity = productQuanity;
        UpdatedBy = "Hoang Huyen Trang";
        UpdatedDate = DateTime.UtcNow;
    }

}
