using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationNAuthorizationDemo.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return Ok("Login Successful");
            }
            else
            {
                return Unauthorized("Invalid Credentials");
            }
        }
    }
}
