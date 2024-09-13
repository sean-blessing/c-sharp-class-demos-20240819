namespace ProductManagerFileIOv2.DB {
    /*
     * ProductDB is a class that will
     * manage the connection and IO
     * with our Products.txt file.
     */
    public class ProductDB {
        string path = @"C:\files\Products.txt";
        List<Product> products = new();

        public ProductDB() {
            // initialize products list
            LoadProducts();
        }

        public List<Product> GetProducts() {
            return products;
        }

        private void LoadProducts() {
            // create a StreamReader to access the file
            using StreamReader productsReader = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            // read the lines from the file
            while (productsReader.Peek() != -1) {
                // parse the fields from each line into a Product
                // add the Product to the products list
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

        public void SaveProducts() {
            // save our list of products in the products.txt file
            // create a StreamWriter to access the file for writing
            using StreamWriter productsWriter = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            // loop through the products list
            foreach (Product product in products) {
                // - streamwriter.write each field separated by '|', end with a newline
                productsWriter.WriteLine($"{product.Code}|{product.Description}|{product.Price}");
            }
        }
    }
}
