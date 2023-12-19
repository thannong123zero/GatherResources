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
            //string url = @"http://103.160.5.59:8001/CSSurvey/index?storenumber=TSHCMNTPSS05";
            AnyBitmap qrlogo = AnyBitmap.FromFile(@"C:\Users\nguye\source\repos\RenderQRcode\RenderQRcode\wwwroot\logo.png");
            QRCodeLogo logo = new QRCodeLogo(qrlogo, 0, 0, 20f);
            GeneratedBarcode barcode = QRCodeWriter.CreateQrCodeWithLogo(model.Url, logo, 250);//QRCodeWriter.CreateQrCode(url, 500);
            //barcode.AddBarcodeValueTextAboveBarcode();
            barcode.SetMargins(10);
            //barcode.ChangeBackgroundColor(Color.Black);
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "QRCode");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string qr = Guid.NewGuid().ToString() + ".png";
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, qr);
            barcode.SaveAsPng(filePath);
            ViewBag.url = qr;
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