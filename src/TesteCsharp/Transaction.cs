using System;

namespace TesteCsharp
{
    public class Transaction
    {
        public string type { get; set; }
        public float quantity { get; set; }
        public double fee { get; set; }
        public double total { get; set; }
        public Stock stock { get; set; }
        public Investor investor { get; set; }

        public Transaction(Investor investor, Stock stock, float quantity, string type)
        {
            this.investor = investor;
            this.stock = stock;
            this.quantity = quantity;
            this.type = type;
            this.fee = investor.fee;
        }
    }
}
