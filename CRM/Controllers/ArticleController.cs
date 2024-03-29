using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
