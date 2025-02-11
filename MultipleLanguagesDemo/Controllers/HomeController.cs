using Microsoft.AspNetCore.Localization;
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
        [HttpGet]
        public IActionResult SetLanguage()
        {
            string languageCode = Globle.GetLanguageCode(Request);
            string vn = ELanguage.VN.ToString();
            if (string.Equals(languageCode, vn))
            {
                TempData["SetLanguage"] = "English";
                Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("en-US")),
                    new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );
            }
            else
            {
                TempData["SetLanguage"] = "VietNamese";
                Response.Cookies.Append(
                   CookieRequestCultureProvider.DefaultCookieName,
                   CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("vi-VN")),
                   new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
               );

            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
