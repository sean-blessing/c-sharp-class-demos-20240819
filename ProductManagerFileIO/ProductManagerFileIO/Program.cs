namespace ProductManagerFileIO {
    internal class Program {
        static List<Product> products = new();
        // Declare file path for use later

        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager App!");

            // LOAD PRODUCTS FROM FILE - into products list

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
        static void ListProducts() {
            Console.WriteLine("\nProduct List:");
            Console.WriteLine("Method Not Yet Implemented");
        }

        static void GetProduct() {
            Console.WriteLine("\nGet Product By Code:");
            Console.WriteLine("Method Not Yet Implemented");
            // prompt user for code
            // find product in list, by code
            // display product
        }

        static void AddProduct() {
            Console.WriteLine("\nAdd a New Product:");
            Console.WriteLine("Method Not Yet Implemented");
            // prompt user for code, desc, price
            // create new instance of product
            // add product to list
            // SAVE PRODUCT FILE
        }

        static void DeleteProduct() {
            Console.WriteLine("\nDelete a Product By Code:");
            Console.WriteLine("Method Not Yet Implemented");
            // prompt user for product code
            // find product by code
            // if product does not exist, display message
            // if product exists, delete product and SAVE PRODUCT FILE
            //
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

        // NEW METHODS:
        // SAVE PRODUCT FILE
        // LOAD PRODUCTS FROM FILE
    }
}
