using Microsoft.AspNetCore.Mvc;

namespace AuthenticationNAuthorizationDemo.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
