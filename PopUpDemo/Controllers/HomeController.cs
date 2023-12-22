using Microsoft.AspNetCore.Mvc;
using PopUpDemo.Helpers;
using PopUpDemo.Models;
using System.Diagnostics;

namespace PopUpDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HomeViewModelHelper _homeViewModelHelper;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _homeViewModelHelper = new HomeViewModelHelper();
        }

        public IActionResult Index()
        {
            List<ProductionViewModel> model = new List<ProductionViewModel>();
            model = _homeViewModelHelper.GetItems();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ProductionViewModel model = new ProductionViewModel();

            return View(model); ;
        }
        [HttpPost]
        public IActionResult Create(ProductionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            bool state = _homeViewModelHelper.AddItem(model);
            if (state)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ProductionViewModel model = _homeViewModelHelper.GetItemByID(id);

            if(model == null)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ProductionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool state = _homeViewModelHelper.UpdateItem(model);

            if (state)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _homeViewModelHelper.DeleteItemByID(id);
            return RedirectToAction("Index");

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