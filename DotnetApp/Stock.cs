using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetApp
{
    public class Stock
    {
        public string TickerSymbol { get; set; }
        public string TickerName { get; set; }
        protected double TickerPrice { get; set; }

        protected double CurrentRatio { get; set; }
        public Stock(string symbol, string name, double price, double currentRatio)
        {
            TickerSymbol = symbol;
            TickerName = name;
            TickerPrice = price;
            CurrentRatio = currentRatio;
        }
        public bool IsStockGood()
        {
            if ((int)CurrentRatio > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public virtual string displayInfo()
        {
            return $"{TickerSymbol} - {TickerName} - {TickerPrice} - {CurrentRatio}";
        }
    }
}
