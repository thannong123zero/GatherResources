using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class MenuItemController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> GetByID()
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
