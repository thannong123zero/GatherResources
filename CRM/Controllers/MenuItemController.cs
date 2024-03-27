using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly MenuGroupHelper _menuGroupHelper;
        private readonly MenuItemHelper _menuItemHelper;
        public MenuItemController(MenuGroupHelper menuGroupHelper, MenuItemHelper menuItemHelper)
        {
            _menuGroupHelper = menuGroupHelper;
            _menuItemHelper = menuItemHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");

            IEnumerable<MenuItemUI> data = await _menuItemHelper.GetMenuItems();

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();

            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuItemUI model)
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();

            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(MenuItemUI model)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
