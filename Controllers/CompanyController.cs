using api.Interfaces;
using Local_Alternatives.Dtos.Account;
using Local_Alternatives.Dtos.Company;
using Local_Alternatives.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Local_Alternatives.Controllers;

[Route("api/company")]
[ApiController]
public class CompanyController : ControllerBase
{
    
    
    private readonly UserManager<AppUser> _userManager;
    private readonly ITokenService _tokenService;
    private readonly SignInManager<AppUser> _signInManager;

    public CompanyController(UserManager<AppUser> userManager, ITokenService tokenService,
        SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
    }
    
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CompanyRegisterDto registerDto)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = new Company()
            {
                UserName = registerDto.UserName,
                Name = registerDto.UserName,
                Email = registerDto.Email,
                Address = registerDto.Address,
                CityId = registerDto.CityId,
            };

            var createdUser = await _userManager.CreateAsync(user, registerDto.Password);

            if (createdUser.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, "Company");
                if (!roleResult.Succeeded)
                {
                    return Ok(
                        new NewCompanyDto()
                        {
                            UserName = user.UserName,
                            Name = user.Name,
                            Email = user.Email,
                            Token = _tokenService.CreateToken(user)
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
            Console.WriteLine(e);
            return StatusCode(500, e);
        }
    }
    
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userManager.Users.FirstOrDefaultAsync(
                x => x.UserName.ToLower() == loginDto.Username.ToLower()
            );

            if (user == null) return Unauthorized("Invalid username or password");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            return Ok(
                new NewCompanyDto()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Token = _tokenService.CreateToken(user)
                }
            );
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e);
        }
    }
}