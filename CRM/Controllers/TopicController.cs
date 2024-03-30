using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class TopicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
