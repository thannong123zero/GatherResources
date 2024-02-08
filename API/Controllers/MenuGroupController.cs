using API.ContextObject;
using API.DTO;
using API.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace API.Controllers
{
    [Route("api/MenuGroup")]
    [ApiController]
    public class MenuGroupController : ControllerBase
    {
        private readonly IMenuGroupRepository _menuGroupRepository;
        public MenuGroupController(IMenuGroupRepository menuGroupRepository)
        {
            _menuGroupRepository = menuGroupRepository;
        }
        [HttpGet]
        [Route("getMenuGroups")]
        public async Task<IActionResult> GetMenuGroups()
        {
            var menugroups = _menuGroupRepository.GetMenuGroups();
            if (menugroups != null)
            {
                return Ok(JsonSerializer.Serialize(menugroups));
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("Test")]
        public async Task<IActionResult> MultipleParameter([FromBody] List<Test> model, [FromHeader] string Index)
        {
            return Ok();
        }

        [HttpPost]
        [Route("LoginFacebook")]
        public string LoginFacebook([FromBody] LoginVM model)
        {
            if (model.UserName == "nguyenhoangtai" && model.Password == "123")
            {

                return " { isValid = true, message = \"đăng nhập thành công\" })";
            }
            return "Json(new { isValid = false, message = \"tài khoảng không chính sát\" })";
        }
    }
    public class Test
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
    public class LoginVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
