using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class ProductListByCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
