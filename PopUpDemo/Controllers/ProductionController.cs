using Microsoft.AspNetCore.Mvc;
using PopUpDemo.Helpers;
using PopUpDemo.Models;

namespace PopUpDemo.Controllers
{
    public class ProductionController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HomeViewModelHelper _homeViewModelHelper;

        public ProductionController(ILogger<HomeController> logger, HomeViewModelHelper homeViewModelHelper)
        {
            _logger = logger;
            _homeViewModelHelper = homeViewModelHelper;
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
        [AutoValidateAntiforgeryToken]
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

            if (model == null)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
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
        public IActionResult Delete(Guid id)
        {
            _homeViewModelHelper.DeleteItemByID(id);
            return RedirectToAction("Index");

        }
    }
}
