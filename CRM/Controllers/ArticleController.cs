using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ArticleUI> data = new List<ArticleUI>()
            {
                new ArticleUI(){ID = new Guid(), SubjectEN = "ABC",SubjectVN = "ancns"},
                new ArticleUI(){ID = new Guid(), SubjectEN = "ABC1",SubjectVN = "ancns"}
            };
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TopicUI model)
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(TopicUI model)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
