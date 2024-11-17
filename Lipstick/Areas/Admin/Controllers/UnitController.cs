using Lipstick._Convergence.BusinessLogic.Helpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace Lipstick.Areas.Admin.Controllers
{
    public class UnitController : Controller
    {
        private readonly UnitHelper _unitHelper;
        public UnitController(UnitHelper unitHelper)
        {
            _unitHelper = unitHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<UnitViewModel> data = await _unitHelper.GetUnits();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            UnitViewModel model = new UnitViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(UnitViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _unitHelper.CreateUnit(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            UnitViewModel data = await _unitHelper.GetUnitByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UnitViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _unitHelper.UpdateUnit(model);
            return RedirectToAction("Index");
        }
    }
}
