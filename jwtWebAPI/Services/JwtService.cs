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

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfiguration.Key));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var claims = new[] {
                    new Claim("FullName", userInfo.FullName+1),
                    new Claim("UserName", userInfo.UserName),
                    new Claim("PassWord", userInfo.Password),
                    new Claim("Role",userInfo.RoleID.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };


                 var token = new JwtSecurityToken(_jwtConfiguration.Issuer,
                    _jwtConfiguration.Audience,
                    claims,
                    expires: DateTime.Now.AddMinutes(_jwtConfiguration.ExpiredTime),
                    signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);
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

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345")),
                ValidateLifetime = false //here we are saying that we don't care about the token's expiration date
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");
            return principal;
        }
    }
}
