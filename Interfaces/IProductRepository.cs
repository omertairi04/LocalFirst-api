using Local_Alternatives.Dtos.Product;
using Local_Alternatives.Models;

namespace api.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIdAsync(Guid id);
    Task<Product> CreateProductAsync(Product product);
    Task<Product?> UpdateProductAsync(Guid id, UpdateProductDto product);
    Task<Product?> DeleteProductAsync(Guid id);
}