namespace Ch12ClassesDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Classes Demo App!");

            // define a class
            // use the class

            // define an integer named 'number' and assign a value of 5
            int number = 5;

            // define a Product named 'p1' and assign values...
            Product p1 = new Product();
            p1.Code = "c#";
            p1.Description = "Murach's C# Programming";
            p1.Price = 57.5m;

            Console.WriteLine($"number: {number}");
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p1 properties: code - {p1.Code}, description - {p1.Description}, price - {p1.Price}");

            p1.Price = 49.99m;

            Console.WriteLine($"p1 properties: code - {p1.Code}, description - {p1.Description}, price - {p1.Price}");

            Product p2 = new Product("java", "Murach's Java Programming", 59.50m);
            Console.WriteLine($"p2: {p2}");

            Product p3 = new Product("andr", "Murach's Android Programming", 62.50m);
            Console.WriteLine($"p3: {p3}");

            Console.WriteLine("pass p1 directly to WriteLine: " + p1.ToString());
            Console.WriteLine(p1);

            List<Product> products = new List<Product>();
            
            products.Add(p1); 
            products.Add(p2); 
            products.Add(p3);

            Console.WriteLine("List of products:");
            foreach (Product p in products) {
                Console.WriteLine(p);
            }

            Console.WriteLine("Find a product by code: ");
            Console.WriteLine("========================");
            Console.Write("Enter code to find: ");
            string code = Console.ReadLine();

            Product foundProduct = null;
            foreach (Product p in products) {
                if (p.Code == code) {
                    foundProduct = p;
                    break;
                }
            }

            if (foundProduct != null) {
                Console.WriteLine($"Found Product: {foundProduct}");
            }
            else {
                Console.WriteLine($"No product found for code: '{code}'");
            }

            //Console.WriteLine($"object count p1: {Product.ObjectCount}");



            // p. 385 Method that accepts parameters

            // p. 387 Constructors

            // p. 389 Static members

            // p. 391 Form - skip

            // p. 403 required parameters - skip

            // p. 405 - skip

            // p. 408 - discuss but skip




            Console.WriteLine("Bye");
        }
    }
}
