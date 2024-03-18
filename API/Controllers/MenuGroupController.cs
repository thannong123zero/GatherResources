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
        [HttpGet]
        [Route("getMenuGroups")]
        public async Task<IActionResult> GetMenuGroups()
        {
            return BadRequest();
        }
        [HttpGet]
        [Route("getMenuGroupByID")]
        public async Task<IActionResult> GetMenuGroupByID(string ID)
        {
            return BadRequest();
        }

        [HttpPost]
        [Route("addMenuGroup")]
        public async Task<IActionResult> AddMenuGroup(MenuGroupUI model)
        {
            if(model == null)
            {
                return BadRequest();
            }
            await _menuGroupHelper.AddMenuGroup(model);
            return Ok();
        }
        [HttpPut]
        [Route("UpdateMenuGroup")]
        public async Task<IActionResult> UpdateMenuGroup(MenuGroupUI model)
        {
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteMenuGroup")]
        public async Task<IActionResult> DeleteMenuGroup(string ID)
        {
            return Ok();
        }
    }
}
