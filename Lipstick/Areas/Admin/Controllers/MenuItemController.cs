using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lipstick.Areas.Admin.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly IMenuGroupHelper _menuGroupHelper;
        private readonly IMenuItemHelper _menuItemHelper;
        public MenuItemController(IMenuGroupHelper menuGroupHelper, IMenuItemHelper menuItemHelper)
        {
            _menuGroupHelper = menuGroupHelper;
            _menuItemHelper = menuItemHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int menuGroupID )
        {
            MenuGroupViewModel seletedMenuGroup = new MenuGroupViewModel();
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = menuGroupList;

            ViewBag.Selected = seletedMenuGroup.NameVN;
            IEnumerable<MenuItemViewModel> data = await _menuItemHelper.GetAllAsync();

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create(string menuGroupID)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN", menuGroupID);
            MenuItemViewModel model = new MenuItemViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuItemViewModel model)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuItemHelper.CreateAsync(model);
            return RedirectToAction("Index", new { menuGroupID = model.MenuGroupID });
        }
        [HttpGet]
        public async Task<IActionResult> Update(int ID)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            MenuItemViewModel data = await _menuItemHelper.GetByIdAsync(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(MenuItemViewModel model)
        {
            IEnumerable<MenuGroupViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuItemHelper.CreateAsync(model);
            return RedirectToAction("Index", new { menuGroupID = model.MenuGroupID });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
