namespace TesteCsharp.Domain.Model
{
    public abstract class Investor
    {
        public double fee { get; protected set; }
        public string name { get; protected set; }

        public Investor(string name)
        {
            this.name = name;
        }
    }
}
