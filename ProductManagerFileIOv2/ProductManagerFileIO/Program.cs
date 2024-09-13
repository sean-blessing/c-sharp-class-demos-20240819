using ProductManagerFileIOv2.DB;

namespace ProductManagerFileIOv2 {
    internal class Program {
        private static ProductDB ProductDB = new ProductDB();

        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager App!");
            
            DisplayMenu();

            string command = "";
            while (command != "exit") {
                Console.Write("Command: ");
                command = Console.ReadLine();
                switch (command) {
                    case "list":
                        ListProducts();
                        break;
                    case "get":
                        GetProduct();
                        break;
                    case "add":
                        AddProduct();
                        break;
                    case "del":
                        DeleteProduct();
                        break;
                    case "menu":
                        DisplayMenu();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

            Console.WriteLine("Bye");
        }

        static string PromptInput(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        static void ListProducts() {
            Console.WriteLine("\nProduct List:");
            foreach (Product product in ProductDB.GetProducts()) {
                Console.WriteLine(product);
            }
            Console.WriteLine();
        }

        static void GetProduct() {
            Console.WriteLine("\nGet Product By Code:");
            // prompt user for code
            string code = PromptInput("Code: ").ToUpper();
            // find product in list, by code
            Product pdt = null;
            foreach(Product product in ProductDB.GetProducts()) {
                if (product.Code == code) {
                    pdt = product;
                }
            }
            // display product
            if (pdt != null) {
                Console.WriteLine(pdt +"\n");
            }
            else {
                Console.WriteLine($"Product for code: {code} not found.\n");
            }
        }

        static void AddProduct() {
            Console.WriteLine("\nAdd a New Product:");
            // prompt user for code, desc, price
            string code = PromptInput("Code: ").ToUpper();
            string desc = PromptInput("Description: ");
            decimal price = Decimal.Parse(PromptInput("Price: "));
            // create new instance of product
            Product p = new Product(code, desc, price);
            // add product to list
            ProductDB.GetProducts().Add(p);
            ProductDB.SaveProducts();
            Console.WriteLine($"Product {code} added!\n");
        }

        static void DeleteProduct() {
            Console.WriteLine("\nDelete a Product By Code:");
            // prompt user for code
            string code = PromptInput("Code: ").ToUpper();
            // find product in list, by code
            Product pdt = null;
            foreach (Product product in ProductDB.GetProducts()) {
                if (product.Code == code) {
                    pdt = product;
                }
            }
            // if product exists, delete product and SAVE PRODUCT FILE
            if ( pdt != null ) {
                ProductDB.GetProducts().Remove(pdt);
                ProductDB.SaveProducts();
                Console.WriteLine($"Product {code} removed.\n");
            }
            else {
                Console.WriteLine($"No Product for code {code} exists.\n");
            }
        }

        static void DisplayMenu() {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("list - list products");
            Console.WriteLine("add  - add a product");
            Console.WriteLine("get  - get a product by code");
            Console.WriteLine("del  - delete a product");
            Console.WriteLine("menu - display menu");
            Console.WriteLine("exit - exit app");
        }
    }

}
