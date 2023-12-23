using jwtWebAPI.Helpers;
using jwtWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jwtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly MasterModelHelper _masterModelHelper;
        public AccountController(MasterModelHelper masterModelHelper)
        {
            _masterModelHelper = masterModelHelper;
        }

        [HttpPost(Name = "Login")]
        public DataObjectResult Login(LoginModel model)
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            UserModel user = _masterModelHelper.Login(model);

            if (user != null)
            {
                dataObjectResult.Ok = true;
                dataObjectResult.Content = user;
                return dataObjectResult;
            }

            dataObjectResult.Message = "UserName or password is isvalid!";
            return dataObjectResult;
        }
    }
}
