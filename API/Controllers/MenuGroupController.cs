using API.IRepositories;
using Microsoft.AspNetCore.Http;
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
            if(menugroups != null)
            {
                return Ok(JsonSerializer.Serialize(menugroups));
            }
            return BadRequest();
        }
    }
}
