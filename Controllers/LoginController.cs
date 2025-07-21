using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamiliaRojanAmaralApi.Models;
using FamiliaRojanAmaralApi.Dtos;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using FamiliaRojahnAmaral_Api.Infra;

namespace FamiliaRojahnAmaral_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserContext _context;

        public LoginController(UserContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<ActionResult<TokenDto>> LoginUser(FamiliaRojanAmaralApi.Infra.UserCredentials creds, ITokenService tokenService)
        {
            User? userLogin = await _context.user.FirstOrDefaultAsync(u => u.email == creds.Username);

            if (userLogin is null)
            {
                return Unauthorized();
            }

            if (!PasswordHasher.Verify(creds.Password, userLogin.password))
            {
                return Unauthorized();

            }

            var newToken = tokenService.CreateToken(userLogin);
            return Ok(new TokenDto { token = newToken });
        }
    }
}
