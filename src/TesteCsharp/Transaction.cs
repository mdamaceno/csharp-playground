using System;

namespace TesteCsharp
{
    public class Transaction : ITransaction
    {
        public string type { get; private set; }
        public float quantity { get; private set; }
        public double fee { get; private set; }
        public double total { get; private set; }
        public Stock stock { get; private set; }
        public Investor investor { get; private set; }

        public Transaction(Investor investor, Stock stock, float quantity, string type)
        {
            this.investor = investor;
            this.stock = stock;
            this.quantity = quantity;
            this.type = type;
            this.fee = investor.fee;
        }

        public static Transaction transact(Transaction transaction)
        {
            transaction.total = transaction.quantity * transaction.stock.price;

            transaction.fee = transaction.total * transaction.investor.fee;
            transaction.total += transaction.fee;

            return transaction;
        }
    }
}
