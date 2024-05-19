namespace StockMarketAnalysis.Models
{
    public class HistoryViewModel
    {
        public double AdjRatio { get; set; }
        public double BuyCount { get; set; }
        public double BuyForeignQuantity { get; set; }
        public double BuyForeignValue { get; set; } 
        public double BuyQuantity { get; set; }
        public double CurrentForeignRoom { get; set; }
        public DateTime Date { get; set; }
        public double DealVolume { get; set; }
        public double PriceAverage { get; set; }
        public double PriceBasic { get; set; }
        public double PriceClose { get; set; }
        public double PriceHigh { get; set; }
        public double PriceLow { get; set; }
        public double PriceOpen { get; set; }
        public double PropTradingNetDealValue { get; set; }
        public double PropTradingNetPTValue { get; set; }
        public double PropTradingNetValue { get; set; }
        public double PutthroughValue { get; set; }
        public double PutthroughVolume { get; set; }
        public double SellCount { get; set; }
        public double SellForeignQuantity { get; set; }
        public double SellForeignValue { get; set; }
        public double SellQuantity { get; set; }
        public string Symbol { get; set; }
        public double TotalValue { get; set; }
        public double TotalVolume { get; set; }
        public double Unit { get; set; }

    }
}
