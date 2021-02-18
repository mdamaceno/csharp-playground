namespace TesteCsharp.Domain.Model
{
    public class Person : Investor
    {
        public Person(string name) : base(name)
        {
            this.fee = 0;
        }
    }
}
