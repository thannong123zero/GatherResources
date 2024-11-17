using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;


namespace Lipstick.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryHelper _menuGroupHelper;
        public CategoryController(ICategoryHelper menuGroupHelper)
        {
            _menuGroupHelper = menuGroupHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryViewModel> data = await _menuGroupHelper.GetAllAsync();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            CategoryViewModel model = new CategoryViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuGroupHelper.CreateAsync(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int ID)
        {
            CategoryViewModel data = await _menuGroupHelper.GetByIdAsync(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _menuGroupHelper.UpdateAsync(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<DatabaseOjectResult> CheckPermissionToDelete(string ID)
        {
            DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
            databaseOjectResult.OK = true;
            databaseOjectResult.Content = "Cai nay duoc phep xoa!" + ID;
            return databaseOjectResult;
        }

        /// <summary>
        /// Action delete The Category
        /// Step 1: Giu yeu cau kiem tra xem co danh muc con khong ?
        /// Step 2: Neu co thi khong cho xoa
        /// Step 2.1: Neu khong co thi cho xoa
        /// Step 3: Thong bao trang thai
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        //[HttpPost]
        //public async Task<DatabaseOjectResult> Delete(int ID)
        //{
        //    DatabaseOjectResult databaseOjectResult = new DatabaseOjectResult();
        //    databaseOjectResult.OK = await _menuGroupHelper.DeleteAsync(ID);
        //    return databaseOjectResult;
        //}
    }
}
