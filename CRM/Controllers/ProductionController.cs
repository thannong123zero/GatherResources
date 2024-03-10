using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class ProductionController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ProductUI> data = new List<ProductUI>() { new ProductUI()
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
