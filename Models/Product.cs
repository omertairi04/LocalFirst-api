namespace Local_Alternatives.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public ICollection<ProductSubCategories>? ProductSubCategories { get; set; } = null!;
    public string CompanyId { get; set; }
    public Company? Company { get; set; }
}