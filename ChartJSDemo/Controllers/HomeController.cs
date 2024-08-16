using ChartJSDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace ChartJSDemo.Controllers
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
        [HttpGet]
        public IActionResult GetBarChart()
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            dataObjectResult.Success = true;

            BarChartViewModel barChartViewModel = new BarChartViewModel();
            barChartViewModel.Title = "Bar Chart";
            barChartViewModel.Unit = "Unit";
            Random random = new Random();

            barChartViewModel.Coloumns = new List<ColoumnViewModel>();
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Jan", Value = random.Next(10, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Feb", Value = random.Next(20, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Mar", Value = random.Next(60, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Apr", Value = random.Next(20, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "May", Value = random.Next(50, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Jun", Value = random.Next(40, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Jul", Value = random.Next(10, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Aug", Value = random.Next(20, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Sep", Value = random.Next(20, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Oct", Value = random.Next(40, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Nov", Value = random.Next(30, 100) });
            barChartViewModel.Coloumns.Add(new ColoumnViewModel { Label = "Dec", Value = random.Next(10, 100) });
            dataObjectResult.Object = JsonSerializer.Serialize(barChartViewModel);
            return Json(dataObjectResult);
        }
        [HttpGet]
        public IActionResult GetLineChart()
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            dataObjectResult.Success = true;
            LineChartViewModel lineChart = new LineChartViewModel();
            lineChart.Title = "Line Chart";
            lineChart.Unit = "Unit";
            Random random = new Random();

            lineChart.Points = new List<PointViewModel>();
            lineChart.Points.Add(new PointViewModel { Label = "Jan", Value = random.Next(10, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Feb", Value = random.Next(20, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Mar", Value = random.Next(60, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Apr", Value = random.Next(20, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "May", Value = random.Next(50, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Jun", Value = random.Next(40, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Jul", Value = random.Next(10, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Aug", Value = random.Next(20, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Sep", Value = random.Next(20, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Oct", Value = random.Next(40, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Nov", Value = random.Next(30, 100) });
            lineChart.Points.Add(new PointViewModel { Label = "Dec", Value = random.Next(10, 100) });
            dataObjectResult.Object = JsonSerializer.Serialize(lineChart);
            return Json(dataObjectResult);
        }
        [HttpGet]
        public IActionResult GetPieChart()
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            dataObjectResult.Success = true;
            PieChartViewModel pieChartView = new PieChartViewModel();
            pieChartView.Title = "Pie Chart";
            pieChartView.Slices = new List<SliceViewModel>();
            Random random = new Random();
            pieChartView.Slices.Add(new SliceViewModel { Lable = "Jan", Value = random.Next(10, 100) });
            pieChartView.Slices.Add(new SliceViewModel { Lable = "Feb", Value = random.Next(20, 100) });
            pieChartView.Slices.Add(new SliceViewModel { Lable = "Mar", Value = random.Next(60, 100) });
            dataObjectResult.Object = JsonSerializer.Serialize(pieChartView);

            return Json(dataObjectResult);
        }
        [HttpGet]
        public IActionResult GetStackHorizontalBarChart()
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            dataObjectResult.Success = true;

            StackBarViewModel stackBarViewModel = new StackBarViewModel();
            stackBarViewModel.Title = "Stack Bar Chart";
            stackBarViewModel.Labels = new List<string> { "Jan", "Feb", "Mar" };
            StackColoumnViewModel stackColoumnViewModel1 = new StackColoumnViewModel();
            stackColoumnViewModel1.Label = "Stack1";
            stackColoumnViewModel1.Coloumns = new List<StackViewModel>()
            {
                new StackViewModel { Label = "Jan", Value = 10 },
                new StackViewModel { Label = "Feb", Value = 20 },
                new StackViewModel { Label = "Mar", Value = 30 },
            };
            stackBarViewModel.Stacks.Add(stackColoumnViewModel1);
            StackColoumnViewModel stackColoumnViewModel2 = new StackColoumnViewModel();
            stackColoumnViewModel2.Label = "Stack2";
            stackColoumnViewModel2.Coloumns = new List<StackViewModel>()
            {
                new StackViewModel { Label = "Jan", Value = 30 },
                new StackViewModel { Label = "Feb", Value = 20 },
                new StackViewModel { Label = "Mar", Value = 10 },
            };
            stackBarViewModel.Stacks.Add(stackColoumnViewModel2);
            StackColoumnViewModel stackColoumnViewModel3 = new StackColoumnViewModel();
            stackColoumnViewModel3.Label = "Stack3";
            stackColoumnViewModel3.Coloumns = new List<StackViewModel>()
            {

                new StackViewModel { Label = "Feb", Value = 30 },
                new StackViewModel { Label = "Mar", Value = 10 },
            };
            stackBarViewModel.Stacks.Add(stackColoumnViewModel3);

            dataObjectResult.Object = JsonSerializer.Serialize(stackBarViewModel);

            return Json(dataObjectResult);
        }
        [HttpGet]
        public IActionResult GetStackVerticalBarChart()
        {

            DataObjectResult dataObjectResult = new DataObjectResult();
            dataObjectResult.Success = true;

            StackBarViewModel stackBarViewModel = new StackBarViewModel();
            stackBarViewModel.Title = "Stack Bar Chart";
            stackBarViewModel.Labels = new List<string> { "Jan", "Feb", "Mar" };
            StackColoumnViewModel stackColoumnViewModel1 = new StackColoumnViewModel();
            stackColoumnViewModel1.Label = "Stack1";
            stackColoumnViewModel1.Coloumns = new List<StackViewModel>()
            {
                new StackViewModel { Label = "Jan", Value = 10 },
                new StackViewModel { Label = "Feb", Value = 20 },
                new StackViewModel { Label = "Mar", Value = 30 },
            };
            stackBarViewModel.Stacks.Add(stackColoumnViewModel1);
            StackColoumnViewModel stackColoumnViewModel2 = new StackColoumnViewModel();
            stackColoumnViewModel2.Label = "Stack2";
            stackColoumnViewModel2.Coloumns = new List<StackViewModel>()
            {
                new StackViewModel { Label = "Jan", Value = 30 },
                new StackViewModel { Label = "Feb", Value = 20 },
                new StackViewModel { Label = "Mar", Value = 10 },
            };
            stackBarViewModel.Stacks.Add(stackColoumnViewModel2);
            StackColoumnViewModel stackColoumnViewModel3 = new StackColoumnViewModel();
            stackColoumnViewModel3.Label = "Stack3";
            stackColoumnViewModel3.Coloumns = new List<StackViewModel>()
            {

                new StackViewModel { Label = "Feb", Value = 30 },
                new StackViewModel { Label = "Mar", Value = 10 },
            };
            stackBarViewModel.Stacks.Add(stackColoumnViewModel3);

            dataObjectResult.Object = JsonSerializer.Serialize(stackBarViewModel);
            return Json(dataObjectResult);
        }
        [HttpGet]
        public IActionResult GetTreeMap()
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            dataObjectResult.Success = true;
            TreeMapViewModel treeMap = new TreeMapViewModel();
            treeMap.Title = "Tree Map";
            treeMap.Name = "Map Name";
            treeMap.Maps = new List<MapViewModel>();
            Random random = new Random();
            treeMap.Maps.Add(new MapViewModel { Name = "Jan", Value = random.Next(10, 100) });
            treeMap.Maps.Add(new MapViewModel { Name = "Feb", Value = random.Next(20, 100) });
            treeMap.Maps.Add(new MapViewModel { Name = "Mar", Value = random.Next(60, 100) });
            treeMap.Maps.Add(new MapViewModel { Name = "Apr", Value = random.Next(20, 100) });
            dataObjectResult.Object = JsonSerializer.Serialize(treeMap);

            return Json(dataObjectResult);
        }
        [HttpGet]
        public IActionResult GetClusteredBarChart()
        {
            DataObjectResult dataObjectResult = new DataObjectResult();
            dataObjectResult.Success = true;
            ClusteredBarChartViewModel clusteredBarChartViewModel = new ClusteredBarChartViewModel();
            clusteredBarChartViewModel.Title = "Clustered Bar Chart";
            clusteredBarChartViewModel.Labels = new List<string> { "Jan", "Feb", "Mar" };
            GroupColoumnViewModel groupColoumnViewModel1 = new GroupColoumnViewModel();
            groupColoumnViewModel1.Label = "Group1";
            groupColoumnViewModel1.Coloumns = new List<ColoumnViewModel>()
            {
                new ColoumnViewModel { Label = "Jan", Value = 10 },
                new ColoumnViewModel { Label = "Feb", Value = 20 },
                new ColoumnViewModel { Label = "Mar", Value = 30 },
            };
            clusteredBarChartViewModel.Groups.Add(groupColoumnViewModel1);
            GroupColoumnViewModel groupColoumnViewModel2 = new GroupColoumnViewModel();
            groupColoumnViewModel2.Label = "Group2";
            groupColoumnViewModel2.Coloumns = new List<ColoumnViewModel>()
            {
                new ColoumnViewModel { Label = "Jan", Value = 30 },
                new ColoumnViewModel { Label = "Feb", Value = 20 },
                new ColoumnViewModel { Label = "Mar", Value = 10 },
            };
            clusteredBarChartViewModel.Groups.Add(groupColoumnViewModel2);
            GroupColoumnViewModel groupColoumnViewModel3 = new GroupColoumnViewModel();
            groupColoumnViewModel3.Label = "Group3";
            groupColoumnViewModel3.Coloumns = new List<ColoumnViewModel>()
            {

                new ColoumnViewModel { Label = "Feb", Value = 30 },
                new ColoumnViewModel { Label = "Mar", Value = 10 },
            };
            clusteredBarChartViewModel.Groups.Add(groupColoumnViewModel3);
            dataObjectResult.Object = JsonSerializer.Serialize(clusteredBarChartViewModel);

            return Json(dataObjectResult);
        }
    }
}
