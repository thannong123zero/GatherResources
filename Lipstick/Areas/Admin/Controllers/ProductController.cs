using Lipstick._Convergence.BusinessLogic.Helpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductHelper _productHelper;
        public ProductController(ProductHelper productHelper)
        {
            _productHelper = productHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductViewModel> data = await _productHelper.GetProducts();
            ViewData["Title"] = "Product List";
            ViewBag.Introduction = "This is the list of products!";
            TempData["Message"] = "This is a message from TempData!";

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ProductViewModel model = new ProductViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _productHelper.CreateProduct(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            ProductViewModel data = await _productHelper.GetProductByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _productHelper.UpdateProduct(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
