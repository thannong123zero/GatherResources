using Lipstick._Convergence.BusinessLogic.Helpers;
using Lipstick.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lipstick.Areas.Admin.Controllers
{
    public class BrandController : Controller
    {
        private readonly BrandHelper _brandHelper;
        public BrandController(BrandHelper brandHelper)
        {
            _brandHelper = brandHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<BrandViewModel> data = await _brandHelper.GetBrands();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            BrandViewModel model = new BrandViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BrandViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //Start checking file
            var file = model.UploadImage;
            long length = file.Length;

            if (length >= 35000)
            {
                // Lenght of file is overflow
                ModelState.AddModelError("UploadImage", "File is too large");
                return View(model);
            }
            string contentType = file.ContentType;
            string typeOfFile = Path.GetExtension(file.FileName);
            if (typeOfFile != ".jpg" && typeOfFile != ".jpeg" && typeOfFile != ".png")
            {
                ModelState.AddModelError("UploadImage", "File is not image");
                return View(model);
            }
            //End checking file

            await _brandHelper.CreateBrand(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string ID)
        {
            BrandViewModel data = await _brandHelper.GetBrandByID(ID);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Update(BrandViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _brandHelper.UpdateBrand(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string ID)
        {
            return View();
        }
    }
}
