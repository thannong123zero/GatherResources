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
            IEnumerable<MenuGroupUI> data = await _menuGroupHelper.GetMenuGroups();
            if(data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
        [HttpGet]
        [Route("getMenuGroupByID")]
        public async Task<IActionResult> GetMenuGroupByID(string ID)
        {
            MenuGroupUI data = await _menuGroupHelper.GetMenuGroupByID(ID);
            if(data == null)
            {
                  return BadRequest();
            }
            return Ok(data);
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
            if(model == null)
            {
                return BadRequest();
            }
            await _menuGroupHelper.UpdateMenuGroup(model);

            return Ok();
        }
        [HttpDelete]
        [Route("DeleteMenuGroup")]
        public async Task<IActionResult> DeleteMenuGroup(string ID)
        {
            if(ID == null)
            {
                return BadRequest();
            }
            await _menuGroupHelper.DeleteMenuGroup(ID);
            return Ok();
        }
    }
}
