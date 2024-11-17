using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleHelper _articleHelper;
        public ArticleController(IArticleHelper articleHelper)
        {
            _articleHelper = articleHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<ArticleViewModel> data = await _articleHelper.GetAllAsync();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ArticleViewModel model = new ArticleViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ArticleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _articleHelper.CreateAsync(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int ID)
        {
            ArticleViewModel data = await _articleHelper.GetByIdAsync(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ArticleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _articleHelper.UpdateAsync(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
