using Microsoft.AspNetCore.Mvc;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StockController : Controller
    {
        public StockController() { }

        [HttpGet()]
        public List<StockModel> GetAllStocks()
        {
            List<StockModel> stocks = new List<StockModel>();

            stocks.Add(new StockModel
            {
                TickerName = "Apple Inc",
                TickerSymbol = "AAPL",
            });

            stocks.Add(new StockModel
            {
                TickerSymbol = "MSFT",
                TickerName = "MicroSoft Inc"
            });
            return stocks;
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
