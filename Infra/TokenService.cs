using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using FamiliaRojanAmaralApi.Models;

namespace FamiliaRojahnAmaral_Api.Infra;

public interface ITokenService
{
    string CreateToken(User user);

}

public class TokenService : ITokenService
{
    private readonly SymmetricSecurityKey _chave;

    public TokenService(IConfiguration config)
    {
        var secret = config["chaveSecreta"];

        if (string.IsNullOrEmpty(secret))
        {
            throw new InvalidOperationException("Missing JWT secret key in configuration.");
        }

        var key = Encoding.UTF8.GetBytes(secret);

        _chave = new SymmetricSecurityKey(key);
    }

    public string CreateToken(User user) {
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.NameId, user.email)
        };

        var credenciais = new SigningCredentials(_chave, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = credenciais
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}
