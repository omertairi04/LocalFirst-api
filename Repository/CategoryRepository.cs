using api.Interfaces;
using Local_Alternatives.Data;
using Local_Alternatives.Models;
using Microsoft.EntityFrameworkCore;

namespace Local_Alternatives.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<ICollection<MainCategory>> GetMainCategoriesAsync()
    {
        try
        {
            return await _context.MainCategories.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ICollection<SubCategory>> GetSubCategoriesAsync()
    {
        try
        {
            return await _context.SubCategories.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ICollection<ProductSubCategories>> GetProductSubCategoriesAsync()
    {
        return await _context.ProductSubCategories
            .Include(p => p.Product)
            .Include(p => p.SubCategory)
            .ToListAsync();
    }

    public async Task<MainCategory?> GetMainCategoryByIdAsync(Guid id)
    {
        try
        {
            return await _context.MainCategories.FirstOrDefaultAsync(c => c.Id == id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<SubCategory?> GetSubCategoryByIdAsync(Guid id)
    {
        try
        {
            return await _context.SubCategories.FirstOrDefaultAsync(c => c.Id == id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ProductSubCategories?> GetProductSubCategoriesByIdAsync(Guid id)
    {
        try
        {
            return await _context.ProductSubCategories
                .Include(p => p.Product)
                .Include(p => p.SubCategory)
                .FirstOrDefaultAsync(c => c.ProductId == id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}