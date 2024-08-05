using Microsoft.AspNetCore.Mvc;

namespace ChartJSDemo.Controllers
{
    public class PieChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
