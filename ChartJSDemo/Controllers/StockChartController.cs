using Microsoft.AspNetCore.Mvc;

namespace ChartJSDemo.Controllers
{
    public class StockChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
