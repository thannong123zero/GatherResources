using Microsoft.AspNetCore.Mvc;

namespace AuthenticationNAuthorizationDemo.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string roleName)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(string roleName)
        {
            return View();
        }
    }
}
