namespace ChartJSDemo.Models
{
    public class PieChartViewModel
    {
        public string Title { get; set; }
        public string ValueField { get; private set; }
        public string LableField { get; private set; }
        public List<PieceViewModel> Pieces { get; set; }
        public PieChartViewModel()
        {
            Title = string.Empty;
            ValueField = "Value";
            LableField = "Lable";
            Pieces = new List<PieceViewModel>();
        }
    }
    public class PieceViewModel
    {
        public string Lable { get; set; }
        public int Value { get; set; }
        public PieceViewModel()
        {
            Lable = string.Empty;
        }
    }
}
