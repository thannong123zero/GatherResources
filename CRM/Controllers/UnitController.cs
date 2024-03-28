using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using SharedLibrary.UserInterfaceDTO;

namespace CRM.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<UnitUI> data = new List<UnitUI>()
            {
                new UnitUI() {ID = new Guid(), NameEN = "abc",NameVN="abc"},
                new UnitUI() {ID = new Guid(), NameEN = "abc1",NameVN="abc1"},
                new UnitUI() {ID = new Guid(), NameEN = "abc2",NameVN="abc2"},
            };

            return View(data);
        }
    }
}
