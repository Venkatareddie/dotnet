using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetApp
{
    public interface ITradeable
    {
        public double buy();

        public double buy(int noOfStocks);
        public double sell();
        public double sell(int noOfStocks);
    }
}
