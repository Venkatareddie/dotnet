namespace OppsProject
{
    public class Stocks
    {
        //Using encapsulation, for to set the value and get values to the data members in the class
        public string ticker_symbol { get; set; }
        public string ticker_name { get; set; }
        public  int open_price { get; set; }
        public int close_price { get; set; }

    }
}
