namespace Local_Alternatives.Models;

public class Company : AppUser
{
    public required string Name { get; set; }
    
    public string Address { get; set; } = string.Empty;
    
    public string City { get; set; } = string.Empty;
}