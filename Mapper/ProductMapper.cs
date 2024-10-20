using Local_Alternatives.Dtos.Product;
using Local_Alternatives.Models;

namespace Local_Alternatives.Mapper;

public static class ProductMapper
{
    public static ProductDto ToProductDto(this Product product)
    {
        return new ProductDto
        {
            Id = product.Id,
            Title = product.Title,
            Description = product.Description,
            Price = product.Price,
            CompanyId = product.CompanyId,
            SubCategoryIds = product.ProductSubCategories != null ? 
                product.ProductSubCategories.Select(psc => psc.SubCategoryId).ToList() 
                : new List<Guid>()
        };
    }

    public static Product ToProductFromCreateDto(this CreateProductDto dto)
    {
        var product = new Product
        {
            Title = dto.Title,
            Description = dto.Description,
            Price = dto.Price,
            CompanyId = dto.CompanyId,
            ProductSubCategories = dto.SubCategoryIds != null
                ? dto.SubCategoryIds.Select(id => new ProductSubCategories { SubCategoryId = id }).ToList()
                : new List<ProductSubCategories>()
        };

        return product;
    }
}