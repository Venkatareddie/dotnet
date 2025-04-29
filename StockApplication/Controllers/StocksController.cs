using Microsoft.AspNetCore.Mvc;
using StockApplication.Interface;
using StockApplication.Model;

namespace StockApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StocksController : ControllerBase
    {
        private IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public List<StockModel> GetAllStocks()
        {
            return _stockService.getAllStocks();
        }

        [HttpPost]

        public List<StockModel> addStock([FromBody] StockModel model)
        {
            return _stockService.insertStock(model);

        }


        [HttpGet("{tickerSymbol}")]
        public List<StockModel> GetStockBySymbol([FromRoute] string tickerSymbol)
        {
            return _stockService.getStocksBySymbol(tickerSymbol);
        }


        [HttpDelete("{symbol}")]
        public IActionResult DeleteStock([FromRoute] string symbol)
        {
            var stock = _stockService.getStocksBySymbol(symbol).FirstOrDefault();
            if (stock == null)
            {
                return NotFound($"Stock with symbol {symbol} not found.");
            }

            _stockService.deleteStock(symbol);
            return NoContent();
        }

        [HttpPut("{tickerSymbol}")]
        public ActionResult<List<StockModel>> UpdateStock(string tickerSymbol, [FromBody] StockModel model)
        {
            var updatedStocks = _stockService.UpdateStock(tickerSymbol, model);
            return Ok(updatedStocks); // Return the updated list of stocks
        }

        [HttpGet("common-stocks")]
        public ActionResult<List<CommonStockModel>> GetAllCommonStocks()
        {
            var stocks = _stockService.GetAllCommonStocks();
            return Ok(stocks);
        }
    }
}
