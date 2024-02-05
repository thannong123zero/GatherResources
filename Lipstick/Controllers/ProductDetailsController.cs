using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
