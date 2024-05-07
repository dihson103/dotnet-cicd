using Domain.Entities;

namespace Application.Data;

public interface IProductRepository
{
    void AddProduct(Product product);
    void DeleteProduct(Product product);
    Task<Product?> FindByIdAsync(Guid id);
    Task<List<Product>> GetAllAsync();
}
