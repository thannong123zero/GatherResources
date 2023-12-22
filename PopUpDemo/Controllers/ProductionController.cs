using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PopUpDemo.Helpers;
using PopUpDemo.Models;
using System.ComponentModel.DataAnnotations.Schema;

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

            return Json(new { isValid = true, titile ="Them San Pham" ,notification = "", html = RenderRazorViewToString(this, "_CreateProduction", model) });

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(ProductionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { isValid = false, notification = "", html = RenderRazorViewToString(this, "_CreateProduction", model) });
            }
            bool state = _homeViewModelHelper.AddItem(model);
            if (!state)
            {
                return Json(new { isValid = false, notification = "", html = RenderRazorViewToString(this, "_CreateProduction", model) });
            }
            List<ProductionViewModel> productionList = new List<ProductionViewModel>();
            productionList = _homeViewModelHelper.GetItems();
            return Json(new { isValid = true, notification = "", html = RenderRazorViewToString(this, "_ProductionList", productionList) });

        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ProductionViewModel model = _homeViewModelHelper.GetItemByID(id);

            if (model == null)
            {
                return Json(new { isValid = false, notification = "", html = ""});
            }
            return Json(new { isValid = true, notification = "", html = RenderRazorViewToString(this, "_EditProduction", model) });

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(ProductionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { isValid = true, notification = "", html = RenderRazorViewToString(this, "_EditProduction", model) });
            }

            bool state = _homeViewModelHelper.UpdateItem(model);

            if (!state)
            {
                return Json(new { isValid = true, notification = "", html = RenderRazorViewToString(this, "_EditProduction", model) });
            }
            List<ProductionViewModel> productionList = new List<ProductionViewModel>();
            productionList = _homeViewModelHelper.GetItems();
            return Json(new { isValid = true, notification = "", html = RenderRazorViewToString(this, "_ProductionList", productionList) });
        }
        public IActionResult Delete(Guid id)
        {
            _homeViewModelHelper.DeleteItemByID(id);
            List<ProductionViewModel> productionList = new List<ProductionViewModel>();
            productionList = _homeViewModelHelper.GetItems();
            return Json(new { isValid = true, notification = "", html = RenderRazorViewToString(this, "_ProductionList", productionList) });
        }
        public string RenderRazorViewToString(Controller controller, string viewName, object model = null)
        {
            controller.ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
                ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);

                ViewContext viewContext = new ViewContext(
                    controller.ControllerContext,
                    viewResult.View,
                    controller.ViewData,
                    controller.TempData,
                    sw,
                    new HtmlHelperOptions()
                );
                viewResult.View.RenderAsync(viewContext);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
