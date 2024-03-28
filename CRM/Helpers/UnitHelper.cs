using Microsoft.AspNetCore.Mvc;

namespace CRM.Helpers
{
    public class UnitHelper : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
