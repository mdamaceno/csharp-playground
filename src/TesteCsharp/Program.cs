using System;

namespace TesteCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock1 = new Stock("VALE3", 30.50, "Brazil");
            Stock stock2 = new Stock("CASH3", 16.00, "Brazil");

            Person investor1 = new Person("Marco Damaceno");
            Transaction transaction1 = new Transaction(investor1, stock1, 3, "compra");
            transaction1 = investor1.Transact(transaction1);

            Company investor2 = new Company("BlackRock");
            Transaction transaction2 = new Transaction(investor2, stock2, 9, "venda");
            transaction2 = investor2.Transact(transaction2);

            Console.WriteLine("========== Relatório de transação nº 1 ==========");
            Console.WriteLine("Nome: " + transaction1.investor.name);
            Console.WriteLine("Quantidade: " + transaction1.quantity);
            Console.WriteLine("Tipo: " + transaction1.type);
            Console.WriteLine("Ticker: " + transaction1.stock.ticker);
            Console.WriteLine("Preço: R$ " + transaction1.stock.price);
            Console.WriteLine("Taxa: R$ " + transaction1.fee);
            Console.WriteLine("Total: R$ " + transaction1.total);
            Console.WriteLine("=================================================");

            Console.WriteLine();

            Console.WriteLine("========== Relatório de transação nº 2 ==========");
            Console.WriteLine("Nome: " + transaction2.investor.name);
            Console.WriteLine("Quantidade: " + transaction2.quantity);
            Console.WriteLine("Tipo: " + transaction2.type);
            Console.WriteLine("Ticker: " + transaction2.stock.ticker);
            Console.WriteLine("Preço: R$ " + transaction2.stock.price);
            Console.WriteLine("Taxa: R$ " + transaction2.fee);
            Console.WriteLine("Total: R$ " + transaction2.total);
            Console.WriteLine("=================================================");
        }
    }
}
