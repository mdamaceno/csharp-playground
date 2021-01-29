namespace TesteCsharp
{
    public class Company : Investor
    {
        public Company(string name) : base(name)
        {
            this.fee = 0.15;
        }
    }
}
