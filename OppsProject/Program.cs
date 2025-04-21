namespace OppsProject
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Stocks s= new Stocks();
            s.ticker_symbol = "AAPL";
            s.ticker_name = "Apple Inc";
            s.open_price = 150;
            s.close_price = 200;

            if(s.open_price > 100)
            {
                Console.WriteLine("Good Price");
            }
            Console.WriteLine($"Ticker Symbol: {s.ticker_symbol}");
            Console.WriteLine($"Ticker Name: {s.ticker_name}");
            Console.WriteLine($"Open Price: {s.open_price}");
            Console.WriteLine($"Close Price: {s.close_price}");

            StockFundamentals sf = new StockFundamentals("CVS", 12, 34, 300, 200);
            sf.display();

            UnionBank unionBank = new UnionBank();
            unionBank.creditTrans();
            unionBank.debitTrans();

            unionBank.transactionFrom(12345);
            unionBank.transactionFrom(12345, 78906);
        }
 
    }
}
