using Microsoft.AspNetCore.Mvc;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class TopicController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<TopicUI> data = new List<TopicUI>()
            {
                new TopicUI(){ID= new Guid(), NameEN="BC", NameVN="vN"},
                new TopicUI(){ID= new Guid(), NameEN="BC", NameVN="vN"},
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
