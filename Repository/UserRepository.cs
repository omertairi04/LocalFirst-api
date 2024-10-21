using System.Security.Claims;
using api.Interfaces;
using Local_Alternatives.Data;
using Local_Alternatives.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Local_Alternatives.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UserRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
    
    public async Task<AppUser> UserData()
    {
        try
        {
            var user = _httpContextAccessor.HttpContext?.User;

            // Ensure that the user is not null
            if (user == null)
            {
                throw new Exception("User context is null");
            }

            // Retrieve the user ID and user role from the claims
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            var userRole = user.FindFirstValue(ClaimTypes.Role);

            Console.WriteLine($"User ID: {userId}, User Role: {userRole}");

            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User ID is null or empty");
            }

            // Retrieve the user data from the database
            var appUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (appUser == null)
            {
                throw new Exception("User not found");
            }

            return appUser;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}