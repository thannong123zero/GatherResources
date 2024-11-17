using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lipstick.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ICategoryHelper _menuGroupHelper;
        private readonly ISubCategoryHelper _menuItemHelper;
        public SubCategoryController(ICategoryHelper menuGroupHelper, ISubCategoryHelper menuItemHelper)
        {
            _menuGroupHelper = menuGroupHelper;
            _menuItemHelper = menuItemHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int menuGroupID )
        {
            CategoryViewModel seletedMenuGroup = new CategoryViewModel();
            IEnumerable<CategoryViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = menuGroupList;

            ViewBag.Selected = seletedMenuGroup.NameVN;
            IEnumerable<SubCategoryViewModel> data = await _menuItemHelper.GetAllAsync();

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create(string menuGroupID)
        {
            IEnumerable<CategoryViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN", menuGroupID);
            SubCategoryViewModel model = new SubCategoryViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubCategoryViewModel model)
        {
            IEnumerable<CategoryViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
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
            IEnumerable<CategoryViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
            ViewBag.MenuGroupList = new SelectList(menuGroupList, "ID", "NameVN");
            SubCategoryViewModel data = await _menuItemHelper.GetByIdAsync(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(SubCategoryViewModel model)
        {
            IEnumerable<CategoryViewModel> menuGroupList = await _menuGroupHelper.GetAllAsync();
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
