using API.ContextObject;
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
        private readonly IMenuGroupRepository _menuGroupRepository;
        private readonly IMapper _mapper;
        public MenuGroupController(IMenuGroupRepository menuGroupRepository,IMapper mapper)
        {
            _menuGroupRepository = menuGroupRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("addMenuGroup")]
        public async Task<IActionResult> AddMenuGroup(MenuGroupUI menuGroupUI)
        {
            if(menuGroupUI == null)
            {
                return BadRequest();
            }
            var menuGroup = _mapper.Map<MenuGroup>(menuGroupUI);
            _menuGroupRepository.Add(menuGroup);

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
