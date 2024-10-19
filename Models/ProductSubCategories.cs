namespace Local_Alternatives.Models;

public class ProductSubCategories
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public Guid SubCategoryId { get; set; }
    public SubCategory SubCategory { get; set; } = null!;
}