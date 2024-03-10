using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class MenuItemController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<MenuItemUI> data = new List<MenuItemUI>()
            {
                new MenuItemUI()
                {
                    ID = Guid.NewGuid(),
                    NameVN = "abc",
                    NameEN = "abc",
                }
            };

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
