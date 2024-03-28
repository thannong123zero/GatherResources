using CRM.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class UnitController : Controller
    {
        private readonly UnitHelper _unitHelper;
        public UnitController(UnitHelper unitHelper) {
        _unitHelper = unitHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<UnitUI> data = await _unitHelper.GetUnits();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(UnitUI model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(UnitUI model)
        {
            return View();
        }
    }
}
