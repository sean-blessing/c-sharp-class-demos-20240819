using System;
using System.ComponentModel.Design;
using System.IO;

namespace Ch17FileIOPrep {
    internal class Program {
        const string DIR = @"c:\files\";
        const string PATH = DIR + "products.txt";
        const string SEP = "|";

        static List<Product> products = new();

        static void Main(string[] args) {
            Console.WriteLine("Welcome to File IO Demo - Products File Edition");
            Console.WriteLine("===============================================\n");

            if (!Directory.Exists(DIR)) {
                Directory.CreateDirectory(DIR);
                Console.WriteLine("dir created");
            }
            else {
                GetProducts();
            }

            string command = "";
            while (command != "exit") {
                DisplayMenu();
                command = GetString("Enter Option: ");
                switch (command) {
                    case "list":
                        listProducts();
                        break;
                    case "add":
                        addProduct();
                        break;
                    case "get":
                        getProduct();
                        break;
                    case "del":
                        delProduct();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Error - invalid command. Try again.");
                        break;
                }
            }


            Console.WriteLine("Bye");
        }

        private static void delProduct() {
            Console.WriteLine("Delete Product");
            Console.WriteLine("==============");
            Product p = FindProduct();
            if (p != null ) {
                products.Remove(p);
            }
            SaveProducts();
            Console.WriteLine("Product Removed.");
        }

        private static void getProduct() {
            Console.WriteLine("Get Product");
            Console.WriteLine("===========");
            Product p = FindProduct();
            if (p != null) {
                Console.WriteLine($"Product found: {p.ToString()}");
            }
        }

        private static void addProduct() {
            Console.WriteLine("Add Product");
            Console.WriteLine("===========");
            string code = GetString("Code:        ");
            string desc = GetString("Description: ");
            decimal price = GetDecimal("Price:    ");
            products.Add(new Product(code, desc, price));
            SaveProducts();
            Console.WriteLine("Product added.");
        }

        private static void listProducts() {
            Console.WriteLine("List All Products");
            Console.WriteLine("=================");
            if (products.Count > 0) { 
                foreach (Product product in products) {
                    Console.WriteLine(product);
                }
            }
            else {
                Console.WriteLine("Products File Empty. Please Add Some Products!");
            }
        }

        static private Product FindProduct() {
            Product p = null;

            Boolean found = false;
            while (!found) {
                string code = GetString("Code: ");
                foreach (Product prod in products) {
                    if (prod.Code == code) {
                        p = prod;
                        found = true;
                        break;
                    }
                }
                if (p == null) {
                    Console.WriteLine("No Product found for code: "+code);
                }
            }

            return p;
        }
        static private string GetString(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static private decimal GetDecimal(string prompt) {
            decimal price = 0;
            Boolean validEntry = false;
            while (!validEntry) {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out price)) {
                    validEntry = true;
                }
                else {
                    Console.WriteLine("Error - enter valid decimal value.");
                }
            }
            return price;
        }

        private static void DisplayMenu() {
            Console.WriteLine("MENU:");
            Console.WriteLine("========================");
            Console.WriteLine("list - List All Products");
            Console.WriteLine("add  - Add a Product");
            Console.WriteLine("get  - Get a Product");
            Console.WriteLine("del  - Delete a Product");
            Console.WriteLine("exit - Exit App");
        }

        public static void SaveProducts() {
            using StreamWriter textOut = new(new FileStream(PATH, FileMode.Create, FileAccess.Write));
            foreach (Product product in products) {
                textOut.Write(product.Code + "|"); textOut.Write(product.Description + "|"); textOut.WriteLine(product.Price);
            }
        }

        public static void GetProducts() {
            using StreamReader textIn = new(
                new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read));
            
            while (textIn.Peek() != -1) {
                string row = textIn.ReadLine() ?? ""; 
                string[] columns = row.Split('|'); 
                if (columns.Length == 3) {
                    Product product = new(columns[0], columns[1], Convert.ToDecimal(columns[2]));
                    products.Add(product);
                }
            } 
        }

    }
}
