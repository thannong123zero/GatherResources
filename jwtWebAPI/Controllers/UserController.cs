using jwtWebAPI.Helpers;
using jwtWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jwtWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MasterModelHelper _masterModelHelper;
        public UserController(MasterModelHelper masterModelHelper)
        {
            _masterModelHelper = masterModelHelper;
        }
        [HttpPost("UpdateProfile")]
        public DataObjectResult UpdateProfile(UserModel model)
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            List<UserModel> users = _masterModelHelper.GetUsers();
            if(users != null)
            {
                dataObjectResult.Ok = true;
                dataObjectResult.Content = users;
                return dataObjectResult;
            }
            dataObjectResult.Message = "No data";

            return dataObjectResult;
        }
        [HttpGet("GetProfile")]
        public DataObjectResult GetProfile(int id)
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            UserModel user = _masterModelHelper.GetUserByID(id);
            if (user != null)
            {
                dataObjectResult.Ok = true;
                dataObjectResult.Content = user;
                return dataObjectResult;
            }
            dataObjectResult.Message = "No data";

            return dataObjectResult;
        }
    }
}
