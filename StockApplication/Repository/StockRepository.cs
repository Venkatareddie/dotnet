using Dapper;
using Npgsql;
using StockApplication.Model;

namespace StockApplication.Repository
{
    public class StockRepository : IStockRepository
    {
        public StockRepository() { }

        public List<StockModel> getAllStocks()
        {
            var stockList = new List<StockModel>();

            var connectionString = "Host=endeavourtech.ddns.net;Port=27443;Database=StocksDB;Username=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                var command = new NpgsqlCommand("SELECT ticker_symbol, ticker_name FROM endeavour.stocks_lookup", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var stock = new StockModel
                        {
                            TickerSymbol = reader["ticker_symbol"].ToString(), 
                            TickerName = reader["ticker_name"].ToString()     
                        };

                        stockList.Add(stock);
                    }
                }
            }

            return stockList;
        }

        public List<StockModel> getAllStocksWithDapper()
        {
            List<StockModel> stocks = new List<StockModel>();
            var connectionString = "host=endeavourtech.ddns.net;Port=27443;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            stocks = connection.Query<StockModel>("Select ticker_symbol as TickerSymbol, ticker_name as TickerName from endeavour.stocks_lookup").ToList();

            connection.Close();
            return stocks;

        }
        public List<CommonStockModel> getAllConnonStocks()
        {
            List<CommonStockModel> stockss = new List<CommonStockModel>();
            var connectionString = "Host=endeavourtech.ddns.net;Port=27443;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            string query = @"
            SELECT 
                sl.ticker_symbol AS TickerSymbol,
                sl.ticker_name AS TickerName,
                sp.trading_date AS TradingDate,
                sp.open_price AS OpenPrice,
                sp.close_price AS ClosePrice,
                sf.sector_id AS SectorId,
                s.sector_name AS SectorName,
                sf.sub_sector_id AS SubSectorId,
                ss.subsector_name AS SubSectorName,
                sf.market_cap AS MarketCap,
                sf.current_ratio AS CurrentRatio
            FROM endeavour.stocks_lookup sl
            LEFT JOIN endeavour.stocks_price_history sp ON sp.ticker_symbol = sl.ticker_symbol
            LEFT JOIN endeavour.stock_fundamentals sf ON sf.ticker_symbol = sl.ticker_symbol
            LEFT JOIN endeavour.sector_lookup s ON s.sector_id = sf.sector_id
            LEFT JOIN endeavour.subsector_lookup ss ON ss.subsector_id = sf.sub_sector_id;
        ";

                var stocks = connection.Query<CommonStockModel>(query).AsList();
                return stocks;
            }
        


    }
}
