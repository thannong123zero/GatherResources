using CRM.Services.APIServices;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;
using System.Reflection;

namespace CRM.Controllers
{
    public class MenuGroupController : Controller
    {

        public async Task<IActionResult> Index()
        {
            TempData["Notification"] = "Them Danh Muc Thanh Cong";
            List<MenuGroupUI> data = new List<MenuGroupUI>() { new MenuGroupUI()
            {
                ID = Guid.NewGuid(),
                NameEN = "LipsticK",
                NameVN = "Son Moi"
            }, new MenuGroupUI() {
                ID = Guid.NewGuid(),
                NameEN = "Blog",
                NameVN = "Blog"
            }
            };
            

            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {         
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuGroupUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View("Index");
        }
        public async Task<IActionResult> Update()
        {
            var data = new MenuGroupUI()
            {
                ID = Guid.NewGuid(),
                NameEN = "LipsticK",
                NameVN = "Son Moi"
            };
            return View(data);
        }
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
