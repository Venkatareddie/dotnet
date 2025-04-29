namespace StockApplication.Model
{
    public class CommonStockModel
    {
        public StockPriceModel StockPrice { get; set; }
        public StockFundamentalModel StockFundamental { get; set; }
        public StockModel Stock { get; set; }
        public SectorModel Sector { get; set; }
        public SubSector SubSector { get; set; }
    }
}
