using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultipleLanguagesDemo.Models;
using System.Diagnostics;

namespace MultipleLanguagesDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IStringLocalizer<SharedResource> _sharedResource;

        public HomeController(ILogger<HomeController> logger,IStringLocalizer<HomeController> localizer, IStringLocalizer<SharedResource> sharedResource)
        {
            _logger = logger;
            _localizer = localizer;
            _sharedResource = sharedResource;
        }

        public IActionResult Index()
        {
            ViewData["hi"] = _sharedResource["hi"];
            ViewData["Message"] = _localizer["homeController"];
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
