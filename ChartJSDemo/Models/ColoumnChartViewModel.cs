namespace ChartJSDemo.Models
{
    public class ColoumnChartViewModel
    {
        public string Title { get; set; }
        public string Type { get; set; } 
        public string ValueYField { get; private set; }
        public string ValueXField { get; private set; }
        public string Unit { get; set; }
        public List<ColoumnViewModel> Coloumns { get; set; }
        public ColoumnChartViewModel()
        {
            Title = string.Empty;
            Type = "horizontal";
            ValueYField = "Value";
            ValueXField = "Lable";
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
