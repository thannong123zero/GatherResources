using API.ContextObject;
using API.IRepositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;
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

        [HttpPost]
        [Route("addMenuGroup")]
        public async Task<IActionResult> AddMenuGroup([FromForm]MenuGroupUI menuGroup)
        {
            if(menuGroup == null)
            {
                return BadRequest();
            }
            //_menuGroupRepository.Add(menuGroup);

            return Ok();
        }


        [HttpGet]
        [Route("getMenuGroups")]
        public async Task<IActionResult> GetMenuGroups()
        {       
            return BadRequest();
        }
    }
}
