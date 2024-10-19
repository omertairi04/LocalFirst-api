namespace Local_Alternatives.Models;

public class SubCategory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdateAt { get; set; } = DateTime.UtcNow;
    public Guid MainCategoryId { get; set; }
    public MainCategory? MainCategory { get; set; }
}