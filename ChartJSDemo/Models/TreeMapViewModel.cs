namespace ChartJSDemo.Models
{
    public class TreeMapViewModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public List<MapViewModel> Maps { get; set; }
        public TreeMapViewModel()
        {
            Title = string.Empty;
            Name = string.Empty;
            Maps = new List<MapViewModel>();
        }
    }
    public class MapViewModel
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public MapViewModel()
        {
            Name = string.Empty;
        }
    }
}
