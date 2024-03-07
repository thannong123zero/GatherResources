using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
