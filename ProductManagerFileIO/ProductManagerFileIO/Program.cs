namespace ProductManagerFileIO {
    internal class Program {
        static List<Product> products = new();
        static string path = @"C:\files\Products.txt";

        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager App!");

            // initialize the list of products
            LoadProducts();
            
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
            foreach (Product product in products) {
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
            foreach(Product product in products) {
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
            products.Add(p);
            SaveProducts();
            Console.WriteLine($"Product {code} added!\n");
        }

        static void DeleteProduct() {
            Console.WriteLine("\nDelete a Product By Code:");
            // prompt user for code
            string code = PromptInput("Code: ").ToUpper();
            // find product in list, by code
            Product pdt = null;
            foreach (Product product in products) {
                if (product.Code == code) {
                    pdt = product;
                }
            }
            // if product exists, delete product and SAVE PRODUCT FILE
            if ( pdt != null ) {
                products.Remove(pdt);
                SaveProducts();
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

        // NEW METHODS:
        
        // SAVE PRODUCT FILE
        private static void SaveProducts() {
            // save our list of products in the products.txt file
            // create a StreamWriter to access the file for writing
            using StreamWriter productsWriter = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            // loop through the products list
            foreach (Product product in products) {
                // - streamwriter.write each field separated by '|', end with a newline
                productsWriter.WriteLine($"{product.Code}|{product.Description}|{product.Price}");
            }
        }
        
        // LOAD PRODUCTS FROM FILE - load into the products list
        private static void LoadProducts() {

            // create a StreamReader to access the file
            using StreamReader productsReader = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            // read the lines from the file
            while (productsReader.Peek() != -1) {
                // parse the fields from each line into a Product
                // add the Product to the products list
                //string row = productsReader.ReadLine() ?? "";
                string row = productsReader.ReadLine();
                string[] fields = row.Split('|');
                if (fields.Length == 3) {
                    string code = fields[0];
                    string desc = fields[1];
                    decimal price = Decimal.Parse(fields[2]);
                    Product p = new Product(code, desc, price);
                    products.Add(p);
                }
            }
        }


    }

}
