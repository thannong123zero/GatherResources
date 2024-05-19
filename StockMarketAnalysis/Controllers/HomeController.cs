using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockMarketAnalysis.Models;
using System.Diagnostics;

namespace StockMarketAnalysis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            StockAnalysisViewModel stock = new StockAnalysisViewModel();
            string url = "https://restv2.fireant.vn/symbols/VHM/historical-quotes?startDate=2024-01-19&endDate=2024-05-19";
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IkdYdExONzViZlZQakdvNERWdjV4QkRITHpnSSIsImtpZCI6IkdYdExONzViZlZQakdvNERWdjV4QkRITHpnSSJ9.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmZpcmVhbnQudm4iLCJhdWQiOiJodHRwczovL2FjY291bnRzLmZpcmVhbnQudm4vcmVzb3VyY2VzIiwiZXhwIjoyMDEzNzQ2Mzc4LCJuYmYiOjE3MTM3NDYzNzgsImNsaWVudF9pZCI6ImZpcmVhbnQud2ViIiwic2NvcGUiOlsib3BlbmlkIiwicHJvZmlsZSIsInJvbGVzIiwiZW1haWwiLCJhY2NvdW50cy1yZWFkIiwiYWNjb3VudHMtd3JpdGUiLCJvcmRlcnMtcmVhZCIsIm9yZGVycy13cml0ZSIsImNvbXBhbmllcy1yZWFkIiwiaW5kaXZpZHVhbHMtcmVhZCIsImZpbmFuY2UtcmVhZCIsInBvc3RzLXdyaXRlIiwicG9zdHMtcmVhZCIsInN5bWJvbHMtcmVhZCIsInVzZXItZGF0YS1yZWFkIiwidXNlci1kYXRhLXdyaXRlIiwidXNlcnMtcmVhZCIsInNlYXJjaCIsImFjYWRlbXktcmVhZCIsImFjYWRlbXktd3JpdGUiLCJibG9nLXJlYWQiLCJpbnZlc3RvcGVkaWEtcmVhZCJdLCJzdWIiOiI3YjRkNGU3Ny04MGM0LTQ4MjEtODZjNy0zN2FmNGIyM2QxYjgiLCJhdXRoX3RpbWUiOjE3MTM3NDYzNzgsImlkcCI6Ikdvb2dsZSIsIm5hbWUiOiJuZ3V5ZW5ob2FuZ3RhaTJrQGdtYWlsLmNvbSIsInNlY3VyaXR5X3N0YW1wIjoiYWFkMzk0NWUtMDhhNS00ODYwLTg4NzUtOTUzNjA0Y2NhZWMzIiwianRpIjoiODM2NjliODViNDNkNzEzZTc3ZTk3NWFlZDY1YjhjOGYiLCJhbXIiOlsiZXh0ZXJuYWwiXX0.mQtBRabeioLfClx4u96us-nXSkDdcfVJps3RMDEkJ9lBVBaSbN_YihMt3sgEqQcdaYLXboveL2EYflmGicAAQyd7sgGCNI91f7a7kkUmyOU4AV8waJTgHuX5ro9QxUzhBmRnBqwTOzsg9zz8rg4S5JqSS-DR2vijGeh2GQdhZzNqv7ZhTP4uNl0rhSWaa2oM1KuWxAA5Q-PbUfZFuhdSgro1u7SFuzVtGwPZAYUlzShi9y2vehRXI_qj0hziUFk7w35fkmzx7OeyVwJFJfyplcqI_ek-WvgxVLXGrPbugFXtNmT6rf82rUJXMjTojwRFnbZA194SwIaqB_jslLFrEw";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                List<HistoryViewModel> history = JsonConvert.DeserializeObject<List<HistoryViewModel>>(data);
                stock.History = history;
            }


            return View(stock);
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
