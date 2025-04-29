namespace StockApplication.Model
{
    public class StockPriceModel
    {
        public string TickerSymbol { get; set; }
        public DateTime TradingDate { get; set; }
        public double OpenPrice { get; set; }
        public double ClosePrice { get; set; }
    }
}