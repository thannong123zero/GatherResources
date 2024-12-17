using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MultipleLanguagesDemo.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStringLocalizer<StoreController> _localizer;
        public StoreController(IStringLocalizer<StoreController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["Message"] = _localizer["storeController"];
            return View();
        }
    }
}
