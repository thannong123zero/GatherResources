using CRM.Helpers;
using CRM.Services.APIServices;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;
using System.Reflection;

namespace CRM.Controllers
{
    public class MenuGroupController : Controller
    {
        private readonly MenuGroupHelper _menuGroupHelper;
        public MenuGroupController(MenuGroupHelper menuGroupHelper)
        {
            _menuGroupHelper = menuGroupHelper;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<MenuGroupUI> data = await _menuGroupHelper.GetMenuGroups();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {         
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuGroupUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuGroupHelper.CreateMenuGroup(model);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(string ID)
        {
            MenuGroupUI data = await _menuGroupHelper.GetMenuGroupByID(ID);
            return View(data);
        }
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
