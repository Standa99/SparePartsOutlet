using Microsoft.IdentityModel.Tokens;
using SparePartsOutletApp.Models.Entities;
using SparePartsOutletApp.Services._Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Numerics;
using System.Security.Claims;
using System.Text;

namespace SparePartsOutletApp.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateLoginToken(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signature = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var claims = new List<Claim>
            {
            new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
            new Claim("userRole", user.RoleName),
            };

            var expiration = DateTime.Now.AddDays(1);

            var jwt = new JwtSecurityToken(issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: signature);

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
