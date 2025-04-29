using StockApplication.Model;

namespace StockApplication.Interface
{
    public interface IStockService
    {
        public List<StockModel> getAllStocks();
        public List<StockModel> insertStock(StockModel stock);

        public List<StockModel> getStocksBySymbol(string symbol);

        public void deleteStock(string symbol);

        public List<StockModel> UpdateStock(string symbol, StockModel updatedStock);

        public List<CommonStockModel> GetAllCommonStocks();

    }
}
