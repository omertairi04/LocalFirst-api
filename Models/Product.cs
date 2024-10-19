namespace Local_Alternatives.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    // Sub Category
    public ICollection<ProductSubCategories>? ProductSubCategories { get; set; } = null!;
    // Location
    // Company
    
}