using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    public class InvoiceController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
