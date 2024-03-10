using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class MenuGroupController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<MenuGroupUI>data = new List<MenuGroupUI>() { new MenuGroupUI()
            {
                ID = Guid.NewGuid(),
                NameEN = "ABC",
                NameVN = "abc"
            } };
            return View(data);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        public async Task<IActionResult> Update()
        {
            return View();
        }
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
