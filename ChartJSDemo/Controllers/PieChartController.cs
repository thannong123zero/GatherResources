using ChartJSDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ChartJSDemo.Controllers
{
    public class PieChartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetPieChart()
        {
            DataObjectResult data = new DataObjectResult();
            data.Success = true;
            PieChartViewModel pieChart = new PieChartViewModel();
            pieChart.Title = "Pie Chart";
            pieChart.Pieces.Add(new PieceViewModel { Lable = "A", Value = 10 });
            pieChart.Pieces.Add(new PieceViewModel { Lable = "B", Value = 20 });
            pieChart.Pieces.Add(new PieceViewModel { Lable = "C", Value = 30 });
            pieChart.Pieces.Add(new PieceViewModel { Lable = "D", Value = 40 });

            data.Object = JsonSerializer.Serialize(pieChart);
            return Json(data);
        }
    }
}
