using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using api.Interfaces;
using Local_Alternatives.Models;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace api.Service;

public class TokenService : ITokenService
{
    private readonly IConfiguration _config;

    private readonly SymmetricSecurityKey _key;

    // IConfiguration - to pull data from appsettings.json
    public TokenService(IConfiguration config)
    {
        _config = config;
        _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SigninKey"]));
    }

    public string CreateToken(AppUser user)
    {
        // CLAIM CONFIG
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(JwtRegisteredClaimNames.GivenName, user.UserName)
        };

        var encryption = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);
        // create token as object
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(7),
            SigningCredentials = encryption,
            Issuer = _config["JWT:Issuer"],
            Audience = _config["JWT:Audience"]
        };
        // create actual token
        var tokenHandler = new JwtSecurityTokenHandler();
        
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}