using CRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CRM.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult ResetPassword()
        //{
        //    return View();
        //}
    }
}
