namespace ChartJSDemo.Models
{
    public class LineChartViewModel
    {
        public string Title { get; set; }
        public string ValueYField { get; private set; }
        public string ValueXField { get; private set; }
        public string Unit { get; set; }
        public List<PointViewModel> Points { get; set; }
        public LineChartViewModel()
        {
            Title = string.Empty;
            ValueYField = "Value";
            ValueXField = "Label";
            Unit = "Unit";
            Points = new List<PointViewModel>();
        }
    }
    public class PointViewModel
    {
        public string Label { get; set; }
        public int Value { get; set; }
        public PointViewModel()
        {
            Label = string.Empty;
        }
    }
}
