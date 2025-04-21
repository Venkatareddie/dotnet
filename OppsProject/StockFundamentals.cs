using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsProject
{
    public class StockFundamentals
    {
        //Data hiding purpose from outside the world by using private access modifier

        private string ticker_symbol;
        private int sector_id;
        private int subsector_id;
        private int market_cap;
        private int current_ratio;

        // Parameterized Constructor
        public StockFundamentals(string ticker_symbol, int sector_id, int subsector_id, int market_cap, int current_ratio)
        {
            this.ticker_symbol = ticker_symbol;
            this.sector_id = sector_id;
            this.subsector_id = subsector_id;
            this.market_cap = market_cap;
            this.current_ratio = current_ratio;
        }

        // Displaying constructor values from the console
        public void display()
        {
            Console.WriteLine($"Ticker Symbol: {ticker_symbol}");
            Console.WriteLine($"Sector Id: {sector_id}");
            Console.WriteLine($"SubSector Id: {subsector_id}");
            Console.WriteLine($"Market Cap: {market_cap}");
            Console.WriteLine($"Current Ratio: {current_ratio}");
        }
    }
}
