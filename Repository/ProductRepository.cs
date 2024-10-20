using api.Interfaces;
using Local_Alternatives.Data;
using Local_Alternatives.Dtos.Product;
using Local_Alternatives.Models;
using Microsoft.EntityFrameworkCore;

namespace Local_Alternatives.Repository;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Product>> GetAllProductsAsync()
    {
        try
        {
            return await _context.Products.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Product?> GetProductByIdAsync(Guid id)
    {
        try
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return null;

            return product;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Product> CreateProductAsync(Product product)
    {
        try
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Product?> UpdateProductAsync(Guid id, UpdateProductDto product)
    {
        try
        {
            var existingProduct = await _context.Products.FindAsync(id);
            if (existingProduct == null) return null;
            existingProduct.Title = product.Title;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.CompanyId = product.CompanyId;
            if (product.SubCategoryIds != null)
            {
                existingProduct.ProductSubCategories = product.SubCategoryIds
                    .Select(id => new ProductSubCategories { SubCategoryId = id})
                    .ToList();
            }
            return existingProduct;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<Product?> DeleteProductAsync(Guid id)
    {
        try
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return null;
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}