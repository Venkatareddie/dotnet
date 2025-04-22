
namespace DotnetApp
{
    public class TechStock:Stock
    {

        public string sector {  get; set; }
        public TechStock(string symbol, string name, double price, double currentRatio, string sector):base(symbol,  name,  price, currentRatio)
        {
           this.sector
                = sector;
        }

        public override string displayInfo()
        {
            return $"TechStock : {TickerSymbol} - {TickerName} - {TickerPrice} - {CurrentRatio} -  {sector}";
        }
    }
}
