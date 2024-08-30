namespace Ch12ClassesDemo {
    public class Product {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        // don't use objectCount... demo purposes only!!!
        static public int ObjectCount { get; set; }

        public Product() {
            ObjectCount++;
        }

        public Product(string code, string description, decimal price) {
            this.Code = code;
            this.Description = description;
            this.Price = price;
            ObjectCount++;
        }

        public override string ToString() {
            return $"Product: Code - '{this.Code}', Description - '{this.Description}', Price - {this.Price}, " +
                $"ObjectCount - {Product.ObjectCount}";
        }



    }
}
