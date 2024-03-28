using Microsoft.AspNetCore.Mvc;

namespace CRM.Services.APIServices
{
    public class UnitAPIService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
