using Local_Alternatives.Models;

namespace api.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}