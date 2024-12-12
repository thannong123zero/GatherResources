using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MultipleLanguagesDemo.Controllers
{
    public class TestIStringLocalizerController : Controller
    {
        private readonly IStringLocalizer<TestIStringLocalizerController> _localizer;

        public TestIStringLocalizerController(IStringLocalizer<TestIStringLocalizerController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewBag.Hi = _localizer["hi"];
            return View();
        }
    }
}
