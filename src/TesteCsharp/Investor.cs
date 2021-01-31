namespace TesteCsharp
{
    public abstract class Investor
    {
        public double fee { get; protected set; }
        public string name { get; protected set; }

        public Investor(string name)
        {
            this.name = name;
        }

        public virtual Transaction Transact(Transaction transaction)
        {
            transaction.total = transaction.quantity * transaction.stock.price;
            transaction.fee = transaction.total * transaction.investor.fee;
            transaction.total += transaction.fee;

            return transaction;
        }
    }
}
