namespace Local_Alternatives.Models;

public class Cities
{
    public Cities(string name, string primaryCity, string country)
    {
        Name = name;
        PrimaryCity = primaryCity ?? "Unknown";  // Default to "Unknown" if missing
        Country = country;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string PrimaryCity { get; set; } = "Unknown";  // Default value
    public string Country { get; set; } = "North Macedonia";
    
    public virtual ICollection<Company> Companies { get; set; }
    public virtual ICollection<NormalUser> NormalUsers { get; set; }
}