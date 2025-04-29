using StockApplication.Model;

namespace StockApplication.Repository
{
    public interface IStockRepository
    {
        public List<StockModel> getAllStocks();
        public List<StockModel> getAllStocksWithDapper();

        public List<CommonStockModel> getAllConnonStocks();
    }
}
