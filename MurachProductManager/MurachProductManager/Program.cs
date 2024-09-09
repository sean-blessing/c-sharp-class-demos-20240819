using MurachProductManager.Models;

namespace MurachProductManager {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager!");

            Console.WriteLine("===  Products ===");
            Book p1 = new Book(1, "c#", "Murach's C#", 59.5m, "Mike Murach");
            Console.WriteLine(p1);
            Book p2 = new Book(2, "JAVA", "Murach's Java Programming", 57.5m, "Mike Murach");
            Console.WriteLine(p2);

            Console.WriteLine("=== Books ===");
            Book b1 = new Book(3, "mysql", "Murach's MySQL", 54.25m, "Joel Murach");
            Console.WriteLine(b1);

            Console.WriteLine("=== Software ===");
            Software s1 = new Software(4, "vsc", "VS Code", 0.0m, "v1.93");
            Console.WriteLine(s1);

            Console.WriteLine("=== List of Products ===");
            List<Product> productsList = new List<Product> { p1, p2, b1, s1};
            PrintProducts(productsList);


            Console.WriteLine("Bye");
        }

        private static void PrintProducts(List<Product> products) {
            foreach (Product product in products) {
                product.PrintToWeb();
            }
        }
    }
}
