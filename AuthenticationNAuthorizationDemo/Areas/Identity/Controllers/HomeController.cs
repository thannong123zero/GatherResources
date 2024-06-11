using Microsoft.AspNetCore.Mvc;

namespace AuthenticationNAuthorizationDemo.Areas.Identity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
