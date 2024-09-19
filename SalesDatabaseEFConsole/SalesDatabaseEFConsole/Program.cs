using SalesDatabaseEFConsole.Db;
using SalesDatabaseEFConsole.Models;

namespace SalesDatabaseEFConsole {
    internal class Program {
        private static CustomerDb custDb = new();
        private static RegionDb regionDb = new();
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Sales DB EF App!!");
            
            Console.WriteLine("======================================");
            List<Customer> list = custDb.GetAll();
            foreach (Customer c in list) {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("======================================");
            List<Region> regionList = regionDb.GetAll();
            foreach (Region r in regionList) {
                Console.WriteLine(r.ToString());
            }
            Console.WriteLine("Bye");
        }
    }
}
