namespace Proj0304ChangeCalculator {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Change Calculator App!");

            string choice = "y";

            while (choice == "y") { 
                // Get user input
                Console.WriteLine("Enter number of cents: ");
                int cents = Int32.Parse(Console.ReadLine());

                // Biz Logic
                // Quarters, Dimes, Nickels, Pennies from cents
                // Use integer math
                int quarters = cents / 25;
                int remainder = cents % 25;
                int dimes = remainder / 10;
                remainder = remainder % 10;
                int nickels = remainder / 5;
                remainder = remainder % 5;
                int pennies = remainder;

                // Display Output - display # of each coin type
                Console.WriteLine($"Quarters: {quarters}");
                Console.WriteLine($"Dimes:    {dimes}");
                Console.WriteLine($"Nickels:  {nickels}");
                Console.WriteLine($"Pennies:  {pennies}");
                Console.Write("Continue (y/n)? ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("bye");
        }
    }
}
