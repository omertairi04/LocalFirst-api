using api.Interfaces;
using Local_Alternatives.Dtos.Account;
using Local_Alternatives.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Local_Alternatives.Controllers;

[Route("api/account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ITokenService _tokenService;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IUserRepository _userRepository;
    public AccountController(UserManager<AppUser> userManager,
        ITokenService tokenService, SignInManager<AppUser> signInManager,
        IUserRepository userRepository)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
        _userRepository = userRepository;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var appUser = new AppUser
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email
            };

            var createdUser = await _userManager.CreateAsync(appUser, registerDto.Password);

            if (createdUser.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                if (roleResult.Succeeded)
                {
                    return Ok(
                        new NewUserDto
                        {
                            UserName = appUser.UserName,
                            Email = appUser.Email,
                            Token = _tokenService.CreateToken(appUser)
                        }
                    );
                }
                else
                {
                    return StatusCode(500, roleResult.Errors);
                }
            }
            else
            {
                return StatusCode(500, createdUser.Errors);
            }
        }
        catch (Exception e)
        {
            return StatusCode(500, e);
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var user = await _userManager.Users.FirstOrDefaultAsync(
            x => x.UserName.ToLower() == loginDto.Username.ToLower());

        if (user == null) return Unauthorized("Invalid User Name");

        var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
        
        if (!result.Succeeded) return Unauthorized("Username or password is incorrect");
        
        return Ok
        (
            new NewUserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            }
        );
    }
    
    /*
     * OTHER ENDPOINTS
     */
    [HttpGet("/profile")]
    [Authorize]
    public async Task<IActionResult> GetProfile()
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userRepository.UserData();

            return Ok(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}