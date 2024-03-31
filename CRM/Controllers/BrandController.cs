using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class BrandController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<BrandUI> data = new List<BrandUI>() { 
                new BrandUI() { Avatar = "Image 1", NameVN = "Gu Tri", NameEN = "Gucci" }, 
                new BrandUI() { Avatar = "Image 2", NameVN = "Stand do", NameEN = "Stander" },
            };
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TopicUI model)
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(TopicUI model)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
