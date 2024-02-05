using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
