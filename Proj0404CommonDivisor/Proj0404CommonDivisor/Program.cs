namespace Proj0404CommonDivisor {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Common Divisor App!");

            string choice = "y";

            while (choice == "y") {
                // Get User Input
                Console.Write("Enter first number: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int y = Int32.Parse(Console.ReadLine());

                // Biz Logic
                // - compare x and y
                // - make the lower # x
                //if (x > y) {
                //    // swap
                //    int originalX = x;
                //    x = y;
                //    y = originalX;
                //}
                while (x != 0) {
                    // - 1 subtract x from y until y < x
                    while (y >= x) {
                        // y = y - x;
                        y -= x;
                    }
                    //    - 2 swap x and y
                    int newX = y;
                    y = x;
                    x = newX;

                }
                Console.WriteLine($"{y} is Greatest Common Divisor");
                // - repeat 1 and 2 until x == 0
                //   - when x is 0, y is gcd

                // Output - display greatestCommonDivisor
                // - print y / gcd
                Console.Write("\nContinue (y/n)? ");
                choice = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Bye");
        }
    }
}
