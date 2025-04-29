using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetApp
{
    public class RetailStock:Stock, ITradeable
    {
        private string sector;
        public RetailStock(string symbol, string name, double price, double currentRatio, string sector) : base(symbol, name, price, currentRatio)
        {
            this.sector
                 = sector;
        }
        public override string displayInfo()
        {
            return $"RetailStock : {TickerSymbol} - {TickerName} - {TickerPrice} - {CurrentRatio} -  {sector}";

        }

        public double buy()
        {
            Console.WriteLine($"Stock bought for: {TickerPrice}");
            return TickerPrice;
        }

        public double buy(int noOfStocks)
        {
            Console.WriteLine($"Stocks bought per share price:{TickerPrice} & Total Cost: {TickerPrice * noOfStocks}");
            return TickerPrice + noOfStocks;

        }

        public double sell()
        {
            Console.WriteLine($"Stock Sold for:  {TickerSymbol}");
            return TickerPrice;
        }
        public double sell(int noOfStocks)
        {

            Console.WriteLine($"Stock sold per share price : {TickerPrice} & Total Value: {TickerPrice * noOfStocks}");
            return TickerPrice * noOfStocks;

        }

    }
}
