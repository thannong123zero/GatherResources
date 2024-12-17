using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MultipleLanguagesDemo.Controllers
{
    public class PromotionController : Controller
    {
        private readonly IStringLocalizer<PromotionController> _localizer;
        public PromotionController(IStringLocalizer<PromotionController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["Message"] = _localizer["promotionController"];
            return View();
        }
    }
}
