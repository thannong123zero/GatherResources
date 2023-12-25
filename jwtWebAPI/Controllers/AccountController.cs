using jwtWebAPI.Helpers;
using jwtWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace jwtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly MasterModelHelper _masterModelHelper;
        private readonly JwtConfiguration _jwtConfiguration;
        public AccountController(MasterModelHelper masterModelHelper, JwtConfiguration jwtConfiguration)
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

            var token = new JwtSecurityToken(_jwtConfiguration.Issuer,
              _jwtConfiguration.Issuer,
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
