namespace StockApplication.Model
{
    public class StockFundamentalModel
    {
        public string tickerSymbol { get; set; }
        public int sectorId {  get; set; }
        public int subSectorId {  get; set; }
        public double marketCap { get; set; }
        public double currentRatio { get; set; }
    }
}
