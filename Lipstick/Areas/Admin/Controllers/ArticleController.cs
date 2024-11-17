using Lipstick._Convergence.BusinessLogic.Helpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly ArticleHelper _articleHelper;
        public ArticleController(ArticleHelper articleHelper)
        {
            _articleHelper = articleHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<ArticleViewModel> data = await _articleHelper.GetArticles();
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
            await _articleHelper.CreateArticle(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            ArticleViewModel data = await _articleHelper.GetArticleByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ArticleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _articleHelper.UpdateArticle(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
