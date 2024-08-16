namespace ChartJSDemo.Models
{
    public class BarChartViewModel
    {
        public string Title { get; set; }
        public string ValueYField { get; private set; }
        public string ValueXField { get; private set; }
        public string Unit { get; set; }
        public List<ColoumnViewModel> Coloumns { get; set; }
        public BarChartViewModel()
        {
            Title = string.Empty;
            ValueYField = "Value";
            ValueXField = "Label";
            Unit = "Unit";
            Coloumns = new List<ColoumnViewModel>();
        }
    }
    public class ColoumnViewModel
    {
        public string Label { get; set; }
        public int Value { get; set; }
        public ColoumnViewModel()
        {
            Label = string.Empty;
        }
    }
}
