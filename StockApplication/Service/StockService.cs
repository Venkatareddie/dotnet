using StockApplication.Interface;
using StockApplication.Model;
using StockApplication.Repository;

namespace StockApplication.Service
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        private readonly List<StockModel> stocks = new List<StockModel>();

        public List<StockModel> getAllStocks()
        {
            return _stockRepository.getAllStocksWithDapper();
        }

        public List<StockModel> insertStock(StockModel stock)
        {
            stocks.Add(stock);
            return stocks;
        }
        public List<StockModel> getStocksBySymbol(string symbol)
        {
            return stocks.Where(s => s.TickerSymbol == symbol).ToList();
        }
        public void deleteStock(string tickerSymbol)
        {
            var stockToRemove = stocks.FirstOrDefault(s => s.TickerSymbol != null && s.TickerSymbol.Equals(tickerSymbol, StringComparison.OrdinalIgnoreCase));
            if (stockToRemove != null)
            {
                stocks.Remove(stockToRemove);
            }
        }
        public List<StockModel> UpdateStock(string symbol, StockModel updatedStock)
        {
            var stock = stocks.Find(s => s.TickerSymbol == symbol);

            if (stock != null)
            {
                stock.TickerName = updatedStock.TickerName;
            }
            else
            {
                stocks.Add(updatedStock);
            }

            return stocks;
        }

        public List<CommonStockModel> GetAllCommonStocks()
        {
            return _stockRepository.getAllConnonStocks();
        }


    }
}
