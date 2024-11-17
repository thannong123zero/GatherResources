using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InvoiceController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
