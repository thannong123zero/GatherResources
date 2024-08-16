namespace ChartJSDemo.Models
{
    public class StackBarViewModel
    {
        public string Title { get; set; }
        public string ValueYField { get; private set; }
        public string ValueXField { get; private set; }
        public string Unit { get; set; }
        public List<StackColoumnViewModel> Stacks { get; set; }
        public List<string> Labels { get; set; }
        public StackBarViewModel()
        {
            Title = string.Empty;
            ValueYField = "Value";
            ValueXField = "Label";
            Unit = "Unit";
            Stacks = new List<StackColoumnViewModel>();
            Labels = new List<string>();
        }
    }
    public class StackColoumnViewModel
    {
        public string Label { get; set; }
        public List<StackViewModel> Coloumns { get; set; }
        public StackColoumnViewModel()
        {
            Label = string.Empty;
            Coloumns = new List<StackViewModel>();
        }
    }
    public class StackViewModel
    {
        public string Label { get; set; }
        public int Value { get; set; }
        public StackViewModel()
        {
            Label = string.Empty;
        }
    }
}
