namespace ChartJSDemo.Models
{
    public class PieChartViewModel
    {
        public string Title { get; set; }
        public string ValueField { get; private set; }
        public string CategoryField { get; private set; }
        public List<SliceViewModel> Slices { get; set; }
        public PieChartViewModel()
        {
            Title = string.Empty;
            ValueField = "Value";
            CategoryField = "Lable";
            Slices = new List<SliceViewModel>();
        }
    }
    public class SliceViewModel
    {
        public string Lable { get; set; }
        public int Value { get; set; }
        public SliceViewModel()
        {
            Lable = string.Empty;
        }
    }
}
