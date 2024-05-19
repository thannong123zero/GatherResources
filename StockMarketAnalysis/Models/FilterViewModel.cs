namespace StockMarketAnalysis.Models
{
    public class FilterViewModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public FilterViewModel()
        {
            FromDate = DateTime.Now.AddMonths(-3);
            ToDate = DateTime.Now;
        }
    }
}
