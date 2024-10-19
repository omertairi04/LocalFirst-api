namespace Local_Alternatives.Models;

public class Company : AppUser
{
    public required string Name { get; set; }
    
    public string Address { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid CityId { get; set; }
    public Cities City { get; set; }
    // Products
    public ICollection<Product> Products { get; set; }
}