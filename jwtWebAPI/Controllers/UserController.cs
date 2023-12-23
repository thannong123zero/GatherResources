using jwtWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public DataObjectResult GetUserProfile()
        {
            return "";
        }
        public DataObjectResult UpdateProfile()
        {
            return "";
        }
    }
}
