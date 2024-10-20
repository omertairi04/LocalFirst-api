using System.ComponentModel.DataAnnotations;

namespace Local_Alternatives.Dtos.Product;

public class CreateProductDto
{
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    [MinLength(3)]
    [MaxLength(250)]
    public string Description { get; set; } = string.Empty; 
    public decimal Price { get; set; }
    public List<Guid>? SubCategoryIds { get; set; }  // Optional for updating the subcategories
    public string CompanyId { get; set; } = string.Empty;
}