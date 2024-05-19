namespace StockMarketAnalysis.Models
{
    public class StockAnalysisViewModel
    {
        public FilterViewModel Filter { get; set; }
        public List<HistoryViewModel> History { get; set; }
        public StockAnalysisViewModel()
        {
            History = new List<HistoryViewModel>();
        }
    }
}
