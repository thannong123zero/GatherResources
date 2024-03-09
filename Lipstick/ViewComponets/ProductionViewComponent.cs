using Microsoft.AspNetCore.Mvc;

namespace Lipstick.ViewComponets
{
    public class ProductionViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
