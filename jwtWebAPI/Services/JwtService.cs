using jwtWebAPI.Helpers;
using jwtWebAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace jwtWebAPI.Services
{
    public class JwtService : IJwtService
    {
        private readonly JwtConfig _jwtConfiguration;
        public JwtService(JwtConfig jwtConfiguration)
        {
            _jwtConfiguration = jwtConfiguration;
        }
        public string GenerateAccessToken(UserModel userInfo)
        {

                var claims = new List<Claim> {
                    new Claim("FullName", userInfo.FullName+1),
                    new Claim("UserName", userInfo.UserName),
                    new Claim("PassWord", userInfo.Password),
                    new Claim("Role",userInfo.RoleID.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

            return CreateToken(claims);
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
        /// <summary>
        /// new TokenValidationParameters
        /// new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345")),
        /// new JwtSecurityTokenHandler();
        /// SecurityToken
        /// new SecurityTokenException("Invalid token");
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public string RenewToken(string expiredToken)
        {

            // Decode the expired token to get its claims
            var handler = new JwtSecurityTokenHandler();
            var expiredTokenObj = handler.ReadToken(expiredToken) as JwtSecurityToken;

            if (expiredTokenObj == null)
            {
                // Invalid token format
                return null;
            }

            // Retrieve user claims from the expired token
            var claims = new List<Claim>(expiredTokenObj.Claims);

            return CreateToken(claims);

        }
    
        private string CreateToken(List<Claim> claims)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfiguration.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_jwtConfiguration.Issuer,
               _jwtConfiguration.Audience,
               claims,
               expires: DateTime.Now.AddMinutes(_jwtConfiguration.ExpiredTime),
               signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
