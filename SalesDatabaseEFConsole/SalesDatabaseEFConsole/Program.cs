using SalesDatabaseEFConsole.Db;
using SalesDatabaseEFConsole.Models;

namespace SalesDatabaseEFConsole {
    internal class Program {
        private static CustomerDb custDb = new();
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Sales DB EF App!!");
            
            Console.WriteLine("======================================");
            List<Customer> list = custDb.GetAll();
            foreach (Customer c in list) {
                Console.WriteLine(c.ToString());
            }


            Console.WriteLine("Bye");
        }
    }
}
