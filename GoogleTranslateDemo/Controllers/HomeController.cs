using Google.Cloud.Translation.V2;
using GoogleTranslateDemo.ModelHelpers;
using GoogleTranslateDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoogleTranslateDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GoogleTransalationHelper _googleTransalationHelper;
        public HomeController(ILogger<HomeController> logger, GoogleTransalationHelper googleTransalationHelper)
        {
            _logger = logger;
            _googleTransalationHelper = googleTransalationHelper;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ResultObject Tranlation([FromBody] TranslationViewModel model)
        {
            ResultObject resultObject = new ResultObject() { Ok = false };
            if (model != null)
            {
                //System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @".\Resource\projecttranslateapi-397007-4c3ee3daa0e2.json");
                //var client = TranslationClient.Create();
                //if (model.Language == "VietNamese")
                //{
                //    TranslationResult result = client.TranslateText(model.Text, LanguageCodes.English);
                //    resultObject.Ok = true;
                //    resultObject.Content = result.TranslatedText;
                //    return resultObject;
                //}
                //else if(model.Language == "English")
                //{
                //    TranslationResult result = client.TranslateText(model.Text, LanguageCodes.Vietnamese);
                //    resultObject.Ok = true;
                //    resultObject.Content = result.TranslatedText;
                //    return resultObject;
                //}
                return _googleTransalationHelper.LanguageTranslation(model);
            }
            return resultObject;
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