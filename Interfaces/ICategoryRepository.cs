using Local_Alternatives.Models;

namespace api.Interfaces;

public interface ICategoryRepository
{
    Task<ICollection<MainCategory>> GetMainCategoriesAsync();
    Task<ICollection<SubCategory>> GetSubCategoriesAsync();
    Task<ICollection<ProductSubCategories>> GetProductSubCategoriesAsync();
    Task<MainCategory?> GetMainCategoryByIdAsync(Guid id);
    Task<SubCategory?> GetSubCategoryByIdAsync(Guid id);
    Task<ProductSubCategories?> GetProductSubCategoriesByIdAsync(Guid id);
}