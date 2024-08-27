namespace Ch04Demos01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to C# Chapter 4 Demos");

            // constants pp. 96 - 97
            // from the book - naming convention for C# per Microsoft
            const int DaysInNovember = 30;
            // Here's how I see it done almost universally:
            const int DAYS_IN_WEEK = 7;

            // binary operators: require two variables
            int a = 5;
            int b = 13;

            int c = a + b;  // + is a binary operator
            int d = b - a;  // - is a binary operator
            // more binary operators
            int e = b / a;
            int f = b % a;  // remainder
            // adding string interpolation pp.288-289
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"f = {f}");

            // doubles
            double g = 13;
            double h = 5;
            double i = g / h;
            Console.WriteLine($"i = {i}");

            // unary operators - single operator on a single variable p. 98
            int count = 0;
            Console.WriteLine($"count: {count}");
            count++;
            Console.WriteLine($"count: {count}");

            // compound assignment operators - p. 101
            count += 5;
            Console.WriteLine($"count: {count}");
            count -= 2;
            Console.WriteLine($"count: {count}");
            // equivalent to...
            count = count + 10;
            Console.WriteLine($"count: {count}");

            // Math class p. 107
            // Round()
            double interestRate = .078453;
            Console.WriteLine($"interestRate: {interestRate}");
            // round to 2 decimal places
            double interstRateRounded = Math.Round(interestRate, 4);
            Console.WriteLine($"interestRate: {interstRateRounded}");

            // formatting p. 121
            // format as percentage
            Console.WriteLine($"interestRate - formatted 1: " +
                $"{interstRateRounded.ToString("p1")}");  // 7.9%
            Console.WriteLine($"interestRate - formatted 2: " +
                $"{interstRateRounded.ToString("p2")}");  // 7.85%

            // format currency
            decimal price1 = 34.99m;
            Console.WriteLine($"price1: {price1}");
            Console.WriteLine($"price1 - formatted: " +
                $"{price1.ToString("c")}");

            Console.WriteLine("bye");
        }
    }
}
