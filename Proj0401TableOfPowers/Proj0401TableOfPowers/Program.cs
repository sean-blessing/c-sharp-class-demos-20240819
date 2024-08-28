namespace Proj0401TableOfPowers {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Table of Powers App!");

            // + begin while loop
            string choice = "y";
            while (choice == "y") {

                // 2 - Get User Input
                Console.Write("\nEnter an integer: ");
                int theNumber = Int32.Parse(Console.ReadLine());

                // 3 - Biz Logic
                // 4 - Display Output
                Console.WriteLine();
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t=======\t=====");
                for (int i = 1; i <= theNumber; i++) {
                    int squared = i * i;
                    int cubed = i * i * i;
                    Console.WriteLine($"{i}\t{squared}\t{cubed}");
                }

                // + End while loop
                Console.Write("\nContinue (y/n)? ");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Bye");
        }
    }
}
