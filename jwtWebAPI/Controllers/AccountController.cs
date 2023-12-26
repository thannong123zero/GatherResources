using jwtWebAPI.Helpers;
using jwtWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace jwtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly MasterModelHelper _masterModelHelper;
        private readonly JwtConfig _jwtConfiguration;
        public AccountController(MasterModelHelper masterModelHelper, JwtConfig jwtConfiguration)
        {
            _masterModelHelper = masterModelHelper;
            _jwtConfiguration = jwtConfiguration;
        }

        [HttpPost(Name = "Login")]
        public IActionResult Login(LoginModel model)
        {
            IActionResult response = Unauthorized();
            UserModel user = _masterModelHelper.Login(model);

            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        private string GenerateJSONWebToken(UserModel userInfo)
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


        //[HttpPost]
        //[Route("refresh")]
        //public IActionResult Refresh(TokenApiModel tokenApiModel)
        //{
        //    if (tokenApiModel is null)
        //        return BadRequest("Invalid client request");
        //    string accessToken = tokenApiModel.AccessToken;
        //    string refreshToken = tokenApiModel.RefreshToken;
        //    var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
        //    var username = principal.Identity.Name; //this is mapped to the Name claim by default
        //    var user = _userContext.LoginModels.SingleOrDefault(u => u.UserName == username);
        //    if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
        //        return BadRequest("Invalid client request");
        //    var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
        //    var newRefreshToken = _tokenService.GenerateRefreshToken();
        //    user.RefreshToken = newRefreshToken;
        //    _userContext.SaveChanges();
        //    return Ok(new AuthenticatedResponse()
        //    {
        //        Token = newAccessToken,
        //        RefreshToken = newRefreshToken
        //    });
        //}


    }
}
