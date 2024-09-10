using System.Linq;

namespace Ch18LinqPrep {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Chapter 18 LINQ - Language INtegrated Query!");

            int[] numbers = { 0, 1, 2, 3, 4};
            Console.WriteLine($"numbers = {DumpIntArrayToString(numbers)}");

            IOrderedEnumerable<int> numberList = from number in numbers
                              where number % 2 == 0
                              orderby number descending
                              select number;

            Console.WriteLine($"numberList (evens) = {DumpIntArrayToString(numberList.ToArray())}");

            // p. 583 - array of decimals as data source
            Console.WriteLine("======================================");
            decimal[] salesTotals =
                new decimal[] { 1286.45m, 2433.49m, 2893.85m, 2094.53m };
            var salesList = from sales in salesTotals select sales;
            decimal sum = 0;
            foreach( var sales in salesList ) {
                sum += sales;
            }

            // p. 585 filter salesTotals array
            salesList = from sales in salesTotals
                        where sales > 2000
                        select sales;

            string salesDisplay = "";
            foreach (var sales in salesList) {
                salesDisplay += sales.ToString("c") + " ";
            }
            Console.WriteLine("Sales over $2k");
            Console.WriteLine(salesDisplay);
            Console.WriteLine("Bye");
        }

        static string DumpIntArrayToString(int[] numbers) {
            string str1 = "";
            foreach (var n in numbers) {
                str1 += n + " ";
            }
            return str1;
        }
    }
}
