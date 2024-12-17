using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MultipleLanguagesDemo.Controllers
{
    public class EventController : Controller
    {
        private readonly IStringLocalizer<EventController> _localizer;
        public EventController(IStringLocalizer<EventController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["Message"] = _localizer["eventController"];
            return View();
        }
    }
}
