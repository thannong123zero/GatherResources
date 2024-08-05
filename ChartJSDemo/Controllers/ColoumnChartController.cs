using ChartJSDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ChartJSDemo.Controllers
{
    public class ColoumnChartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetColoumChart()
        {
            DataObjectResult data = new DataObjectResult();
            data.Success = true;
            ColoumnChartViewModel coloumnChart = new ColoumnChartViewModel();
            coloumnChart.Title = "Coloumn Chart";
            coloumnChart.Unit = "Unit";
            coloumnChart.Coloumns.Add(new ColoumnViewModel { Lable = "A", Value = 10 });
            coloumnChart.Coloumns.Add(new ColoumnViewModel { Lable = "B", Value = 20 });
            coloumnChart.Coloumns.Add(new ColoumnViewModel { Lable = "C", Value = 30 });
            coloumnChart.Coloumns.Add(new ColoumnViewModel { Lable = "D", Value = 40 });
            coloumnChart.Coloumns.Add(new ColoumnViewModel { Lable = "E", Value = 50 });

            data.Object = JsonSerializer.Serialize(coloumnChart);
            return Json(data);
        }
    }
}
