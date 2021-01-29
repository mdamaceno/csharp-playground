namespace TesteCsharp
{
    public interface ITransaction
    {
        string type { get; }
        float quantity { get; }
        double fee { get; }
        double total { get; }
        Stock stock { get; }
        Investor investor { get; }
    }
}
