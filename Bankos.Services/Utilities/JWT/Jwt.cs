using Bankos.DB.Models;
using Bankos.DB.Responses;
using Bankos.Services.DTOs.Users.AuthDTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bankos.Services.Utilities.JWT
{
    public class Jwt : IJwt
    {
        private readonly string _key;
        private readonly string _audience;
        private readonly string _issuer;
        private readonly int _duration;
        private readonly IConfiguration _configuration;

        public Jwt(IConfiguration configuration)
        {
            _configuration = configuration;
            _key = _configuration.GetSection("Jwt:Key").Value;
            _audience = _configuration.GetSection("Jwt:Audience").Value;
            _issuer = _configuration.GetSection("Jwt:Issuer").Value;
            _duration = int.Parse(_configuration.GetSection("Jwt:Duration").Value);
        }

        public TokenDTO CreateUserToken(User user)
        {
            var response = new GenericResponseModel<LoginSuccessDTO>();

            JwtSecurityToken jwtSecurityToken = GenerateNewJwtToken(user);
            JwtSecurityTokenHandler jwtHandler = new();
            string stringToken = jwtHandler.WriteToken(jwtSecurityToken);
            return new LoginSuccessDTO() { FullName = user.FullName, ExpiresOn = jwtSecurityToken.ValidTo, Token = stringToken };
        }

        private JwtSecurityToken GenerateNewJwtToken(User user)
        {
            List<Claim> userClaims = new()
            {
                new Claim("id", user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.UserRole.NormalizedRoleName)
            };
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: userClaims,
                issuer: _issuer,
                audience: _audience,
                expires: DateTime.Now.AddMinutes(_duration),
                signingCredentials: signingCredentials);

            return token;
        }
    }
}
