using System.ComponentModel.DataAnnotations;

namespace Local_Alternatives.Dtos.NormalUser;

public class NormalUserRegisterDto
{
    [Required] public string? UserName { get; set; }
    public string? Address { get; set; }
    [Required] [EmailAddress] public string? Email { get; set; }
    [Required] public string? Password { get; set; }
    [Required] public Guid CityId { get; set; }
}