using Local_Alternatives.Models;

namespace api.Interfaces;

public interface IUserRepository
{
    Task<AppUser> UserData();
}