namespace ProductManagerFileIO {
    public class Product {

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string code, string desc, decimal price) {
            Code = code;
            Description = desc;
            Price = price;
        }

        public override string ToString() {
            return $"Product: Code: {Code}, Description: {Description}, Price: {Price}";
        }
    }
}