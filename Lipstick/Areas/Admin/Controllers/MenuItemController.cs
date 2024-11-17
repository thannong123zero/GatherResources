using Lipstick._Convergence.BusinessLogic.Helpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lipstick.Areas.Admin.Controllers
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
        public async Task<IActionResult> Index(string menuGroupID = "")
        {
            MenuGroupViewModel seletedMenuGroup = new MenuGroupViewModel();
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = menuGroupList;
            if (string.IsNullOrEmpty(menuGroupID))
            {
                seletedMenuGroup = menuGroupList.First();
                menuGroupID = seletedMenuGroup.ID.ToString();
            }
            else
            {
                Guid ID = Guid.Parse(menuGroupID);
                seletedMenuGroup = menuGroupList.Where(s => s.ID == ID).FirstOrDefault();
            }
            ViewBag.Selected = seletedMenuGroup.NameVN;
            IEnumerable<MenuItemViewModel> data = await _menuItemHelper.GetMenuItems(menuGroupID);

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create(string menuGroupID)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN", menuGroupID);
            MenuItemViewModel model = new MenuItemViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuItemViewModel model)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuItemHelper.CreateMenuItem(model);
            return RedirectToAction("Index", new { menuGroupID = model.MenuGroupID });
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (string.IsNullOrEmpty(ID))
            {
                return RedirectToAction("Index");
            }
            MenuItemViewModel data = await _menuItemHelper.GetMenuItemByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(MenuItemViewModel model)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetMenuGroups();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuItemHelper.UpdateMenuItem(model);
            return RedirectToAction("Index", new { menuGroupID = model.MenuGroupID });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
