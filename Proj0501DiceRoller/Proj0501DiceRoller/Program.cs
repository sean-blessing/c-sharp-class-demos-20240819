namespace Proj0501DiceRoller {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Dice Roller!");
            const int MAX_DIE_VAL = 7;

            // + start of while loop
            // user input - roll again? (y/n)
            string rollDice = getString("Roll the dice (y/n) ? ");
            while (rollDice == "y") {

                // biz logic - roll the dice and calc the sum
                // generate two random ints between 1 and 6
                int die1 = GetDie(MAX_DIE_VAL);
                int die2 = GetDie(MAX_DIE_VAL);
                int sum = die1 + die2;

                // display output
                // - die rolls
                // - sum
                // - special message, if necessary
                Console.WriteLine($"\nDie 1: {die1}");
                Console.WriteLine($"Die 2: {die2}");
                Console.WriteLine($"Total: {sum}");
                if (sum == 2) { 
                    Console.WriteLine("Snake Eyes!");
                }
                else if (sum == 12) {
                    Console.WriteLine("Box Cars!");
                }
                Console.WriteLine();

                // + end of while loop
                rollDice = getString("Roll again (y/n) ? ");
            }
            Console.WriteLine("bye");
        }

        private static int GetDie(int maxVal) {
            return new Random().Next(1, maxVal);
        }

        private static string getString(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
