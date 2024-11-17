using Lipstick._Convergence.BusinessLogic.IHelpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    public class UnitController : Controller
    {
        private readonly IUnitHelper _unitHelper;
        public UnitController(IUnitHelper unitHelper)
        {
            _unitHelper = unitHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<UnitViewModel> data = await _unitHelper.GetAllAsync();
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
            await _unitHelper.CreateAsync(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int ID)
        {
            UnitViewModel data = await _unitHelper.GetByIdAsync(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UnitViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _unitHelper.UpdateAsync(model);
            return RedirectToAction("Index");
        }
    }
}
