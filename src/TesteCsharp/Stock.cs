namespace TesteCsharp
{
    public class Stock
    {
        public string ticker { get; private set; }
        public double price { get; private set; }
        public string country { get; private set; }

        public Stock(string ticker, double price, string country)
        {
            this.ticker = ticker;
            this.price = price;
            this.country = country;
        }

        public static double increasePrice(Stock stock, double value)
        {
            return stock.price + value;
        }

        public static double decreasePrice(Stock stock, double value)
        {
            return stock.price - value;
        }
    }
}
