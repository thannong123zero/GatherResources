using LoggingProjectDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoggingProjectDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Home page visited");
            _logger.LogWarning("This is a warning message");
            _logger.LogError("This is an error message");
            _logger.LogCritical("This is a critical message");
            _logger.LogDebug("This is a debug message");
            _logger.LogTrace("This is a trace message");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
