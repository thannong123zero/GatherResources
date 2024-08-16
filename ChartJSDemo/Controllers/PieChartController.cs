using ChartJSDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ChartJSDemo.Controllers
{
    public class PieChartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
