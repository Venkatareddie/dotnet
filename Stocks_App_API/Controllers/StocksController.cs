using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Stocks_App_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StocksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStocks()
        {
            var stocks = new List<StocksModel>
            {
                new StocksModel { TickerSymbol = "AAPL", TickerName = "Apple Inc." },
                new StocksModel { TickerSymbol = "GOOGL", TickerName = "Alphabet Inc." },
                new StocksModel { TickerSymbol = "MSFT", TickerName = "Microsoft Corporation" }
            };

            return Ok(stocks);
        }
    }
}
