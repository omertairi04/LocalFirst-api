using Local_Alternatives.Models;

namespace Local_Alternatives.Dtos.Product;

public class ProductDto
{
    public Guid Id { get; set; }
    public string? Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public List<Guid> SubCategoryIds { get; set; } = new List<Guid>();
    public string CompanyId { get; set; }
    public Models.Company? Company { get; set; }
}