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
        public async Task<IActionResult> Index()
        {
            IEnumerable<UnitUI> data = await _unitHelper.GetUnits();
            return View(data);
        }
    }
}
