using Microsoft.AspNetCore.Mvc;
using PopUpDemo.Helpers;
using PopUpDemo.Models;
using System.Diagnostics;

namespace PopUpDemo.Controllers
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
            HomeViewModelHelper homeViewModelHelper = new HomeViewModelHelper();
            List<ProductionViewModel> model = new List<ProductionViewModel>();
            model = homeViewModelHelper.GetItems();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View();
        }

        public IActionResult Edit(Guid id)
        {
            return View();
        }


        public IActionResult Delete(Guid id)
        {
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