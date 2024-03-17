using API.ContextObject;
using API.Helpers;
using API.IRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.DTO;
using SharedLibrary.UserInterfaceDTO;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace API.Controllers
{
    [Route("api/MenuGroup")]
    [ApiController]
    public class MenuGroupController : ControllerBase
    {
        private readonly MenuGroupHelper _menuGroupHelper;
        public MenuGroupController(MenuGroupHelper menuGroupHelper)
        {
            _menuGroupHelper = menuGroupHelper;
        }

        [HttpPost]
        [Route("addMenuGroup")]
        public async Task<IActionResult> AddMenuGroup(MenuGroupUI menuGroupUI)
        {
            if(menuGroupUI == null)
            {
                return BadRequest();
            }
            _menuGroupHelper.AddMenuGroup(menuGroupUI);
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
