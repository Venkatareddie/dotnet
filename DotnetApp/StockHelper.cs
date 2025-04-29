using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetApp
{
    static class StockHelper
    {
        public static double TotalStockValue(double stockPrice, int noOfStocks)
        {
            return stockPrice * noOfStocks;
        }

    }
}
