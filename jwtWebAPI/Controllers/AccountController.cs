using jwtWebAPI.Helpers;
using jwtWebAPI.Models;
using jwtWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
        private readonly IJwtService _jwtService;

        public AccountController(MasterModelHelper masterModelHelper, JwtConfig jwtConfiguration, IJwtService jwtService)
        {
            _masterModelHelper = masterModelHelper;
            _jwtConfiguration = jwtConfiguration;
            _jwtService = jwtService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginModel model)
        {
            IActionResult response = Unauthorized();
            UserModel user = _masterModelHelper.Login(model);

            if (user != null)
            {
                string token = _jwtService.GenerateAccessToken(user);
                string refreshToken = _jwtService.GenerateRefreshToken();

                RefreshTokenModel refresh = new RefreshTokenModel();

                refresh.Token = token;
                refresh.KeyRefresh = refreshToken;
                if (!_masterModelHelper.AddRefreshToken(refresh))
                {
                    return BadRequest("Can't save token");
                }

                response = Ok(new { token , refreshToken  });
            }

            return response;
        }


        [HttpPost]
        [Route("RefreshToken")]
        public IActionResult RefreshToken(string keyRefresh, string token)
        {
            if (string.IsNullOrEmpty(keyRefresh) || string.IsNullOrEmpty(token))
                return BadRequest("KeyRefresh or Token is Invalid");

            bool state = _masterModelHelper.CheckIsValidToken(keyRefresh, token);

            if (!state)
                return BadRequest("Invalid");

            string newAccessToken = _jwtService.RenewToken(token);
            string newRefreshToken = _jwtService.GenerateRefreshToken();

            RefreshTokenModel refreshToken = new RefreshTokenModel();

            refreshToken.Token = newAccessToken;
            refreshToken.KeyRefresh = newRefreshToken;

            if (!_masterModelHelper.AddRefreshToken(refreshToken))
            {
                return BadRequest("Can't save token");
            }

            return Ok(new
            {
                Token = newAccessToken,
                RefreshToken = newRefreshToken
            });
        }


    }
}
