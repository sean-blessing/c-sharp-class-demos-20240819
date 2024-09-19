using MurachProductManager.Models;

namespace MurachProductManager {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager!");

            Console.WriteLine("===  Products ===");
            Book b1 = new Book(1, "c#", "Murach's C#", 59.5m, "Mike Murach");
            Console.WriteLine(b1);
            Book b2 = new Book(2, "JAVA", "Murach's Java Programming", 57.5m, "Mike Murach");
            Console.WriteLine(b2);

            Console.WriteLine("=== Books ===");
            Book b3 = new Book(3, "mysql", "Murach's MySQL", 54.25m, "Joel Murach");
            Console.WriteLine(b3);

            Console.WriteLine("=== Software ===");
            Software s1 = new Software(4, "vsc", "VS Code", 0.0m, "v1.93");
            Console.WriteLine(s1);

            Console.WriteLine("=== List of Products ===");
            List<Product> productsList = new List<Product> { b1, b2, b3, s1};
            PrintProducts(productsList);

            // polymorphism discussion 9/19/24
            // The above productsList<Product> demonstrates polymorphism - one list containing both books and sofware

            //List<Book> books = new List<Book> { p1, p2, b1, s1 };
            //List<Software> software = new List<Software> { p1, p2, b1, s1 };



            Console.WriteLine("Bye");
        }

        private static void PrintProducts(List<Product> products) {
            foreach (Product product in products) {
                product.PrintToWeb();
                //Console.WriteLine(product.Author);
                //Console.WriteLine(product.Version);
                //Console.WriteLine(product.Code);
            }
        }
    }
}
