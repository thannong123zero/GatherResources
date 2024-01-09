using CreateQRCodeDemo.Models;
using IronBarCode;
using IronSoftware.Drawing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CreateQRCodeDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(QRViewModel model)
        {
            string url = model.Url;
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "QRCodeStore");
            string fileName = string.Concat(Guid.NewGuid(), ".png");

            AnyBitmap qrlogo = AnyBitmap.FromFile("./wwwroot/assets/favicon.png");
            QRCodeLogo logo = new QRCodeLogo(qrlogo, 0, 0, 20f);
            GeneratedBarcode barcode = QRCodeWriter.CreateQrCodeWithLogo(url, logo, 250);
            barcode.AddAnnotationTextBelowBarcode("My Channel");
            barcode.ChangeBackgroundColor(System.Drawing.ColorTranslator.FromHtml("#2A0066"));
            barcode.ChangeBarCodeColor(System.Drawing.Color.Red,true);

            barcode.SetMargins(10);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = Path.Combine(path, fileName);
            barcode.SaveAsPng(filePath);
            ViewBag.fileName = fileName;

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}