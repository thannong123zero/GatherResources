using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly MenuGroupHelper _menuGroupHelper;
        public MenuItemController(MenuGroupHelper menuGroupHelper)
        {
            _menuGroupHelper = menuGroupHelper;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");

            List<MenuItemUI> data = new List<MenuItemUI>()
            {
                new MenuItemUI()
                {
                    ID = Guid.NewGuid(),
                    NameVN = "abc",
                    NameEN = "abc",
                }
            };

            return View(data);
        }
        public async Task<IActionResult> Create()
        {
            IEnumerable<MenuGroupUI> menuGroupList = await _menuGroupHelper.GetMenuGroups();

            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            return View();
        }
        public async Task<IActionResult> Update()
        {
            return View();
        }
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
