namespace Ch18Linq {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to LINQ!");

            // p. 578 - LINQ - Language Integrated Query

            // p. 581

            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("List of numbers using foreach:");
            foreach (int number in numbers) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Even numbers using foreach:");
            foreach (int number in numbers) {
                if (number % 2 == 0) {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();


            Console.WriteLine("Odd numbers, reversed, using indexed for:");
            for (int i = numbers.Length - 1; i >= 0; i--) {
                if (numbers[i] % 2 != 0) {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("=========   LINQ  Queries   ============");

            Console.WriteLine("List of numbers using LINQ:");
            var numberList = from number in numbers
                             select number;

            foreach (int number in numberList) {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Even numbers using LINQ:");
            numberList = from number in numbers
                             where number % 2 == 0
                             select number;
            foreach (int number in numberList) {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Odd numbers, reversed, using LINQ:");
            numberList = from number in numbers
                         where number % 2 != 0
                         orderby number descending
                         select number;

            foreach (int number in numberList){
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // p. 583
            decimal[] salesTotals = new decimal[] { 1286.45m, 2433.49m, 2893.85m, 2094.53m};
            var salesList = from sales in salesTotals
                            select sales;

            decimal sum = 0;
            foreach(var sale in salesList) {
                sum += sale;
            }

            Console.WriteLine($"sum: {sum}");

            // p. 585 filtering

            salesList = from sales in salesTotals
                        where sales > 2000
                        select sales;
            string salesDisplay = "";
            foreach (var sale in salesList) {
                salesDisplay += sale.ToString("c") + " ";
            }

            Console.WriteLine($"salesDisplay: {salesDisplay}");

            Console.WriteLine("Bye");
        }
    }
}
