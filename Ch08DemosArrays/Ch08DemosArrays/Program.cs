namespace Ch08DemosArrays {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Chapter 8- Arrays and Collections!");

            // p. 230 One Dimensional Arrays
            // p. 231 Basic Array Demos
            string[] names = { "Sean", "Brandon", "Chris", "Holly", "Sarika", "Brendan", "Graham", "Graydon"};
            int[] numbers = new int[10];
            Console.WriteLine($"names: {names}");
            Console.WriteLine($"numbers: {numbers}");

            // p. 233 Assigning Values to Arrays
            // Add numbers to numbers array
            numbers[0] = 2;
            numbers[1] = 4;
            numbers[2] = 6;
            numbers[3] = 8;
            numbers[4] = 10;
            numbers[5] = 12;
            numbers[6] = 14;

            // Assigning and Creating at the same time
            decimal[] prices = { 25.99m, 14.25m, 9.99m, 1.49m, 99.99m };

            // p. 235 Working w/ Arrays - average, populating
            decimal sum = prices[0] + prices[1] + prices[2] + prices[3] + prices[4];
            Console.WriteLine($"sum of prices: {sum}");
            Console.WriteLine($"avg of prices: {sum / prices.Length}");

            // loop through numbers array, print each #, and add it to a total
            int total = 0;
            for ( int i = 0; i < numbers.Length; i++ ) {
                Console.WriteLine($"i:{i} - numbers[{i}] = {numbers[i]}");
                total += numbers[i];
            }
            Console.WriteLine($"total: {total}");

            // p. 237 For each loop
            // loop through names, printing each name
            foreach ( string name in names ) {
                Console.WriteLine(name);
            }

            // Add a new name to our names array - Denise
            for ( int i = 0;i < names.Length;i++ ) {
                Console.WriteLine($"names[{i}]: {names[i]}");
            }

            // add Denise
            // names[8] = "Denise"; - IndexOutOfBoundsException

            // p. 239 Rectangular Arrays
            // create 2x2 array of our names w/ a header
            string[,] namesTable = new string[9,2];
            namesTable[0, 0] = "First";
            namesTable[0, 1] = "Last";
            namesTable[1, 0] = "Sean";
            namesTable[1, 1] = "Blessing";
            namesTable[2, 0] = "Chris";
            namesTable[2, 1] = "Silver";
            namesTable[3, 0] = "Brandon";
            namesTable[3, 1] = "Moore";
            namesTable[4, 0] = "Graham";
            namesTable[4, 1] = "Arnett";
            namesTable[5, 0] = "Sarika";
            namesTable[5, 1] = "Srivestava";
            namesTable[6, 0] = "Gradon";
            namesTable[6, 1] = "Kappes";
            namesTable[7, 0] = "Holly";
            namesTable[7, 1] = "Hoffman";
            namesTable[8, 0] = "Brendan";
            namesTable[8, 1] = "Keam";

            for (int i = 0; i < namesTable.GetLength(0); i++) {
                for (int j = 0; j < namesTable.GetLength(1); j++) {
                    //Console.WriteLine($"namesTable[{i},{j}]: {namesTable[i, j]}");
                    Console.Write($"{namesTable[i, j]}\t");
                }
                Console.WriteLine();
            }

            // p. 241 Working with the Numbers Array

            // p. 243 Arrays Class

            // p. 245 Reference to an Array

            // p. 247 

            // p. 249

            // p. 251 More ways to refer to Array elements

            // p. 253 List patterns

            // p. 257 Collections

            // p. 259 List implementations

            // p. 261 List examples

            // p. 263 Create and load a sorted list

            // p. 265 Looking up values based on key

            // p. 267 Queues

            // p. 269 Using ArrayLists

            Console.WriteLine("Bye");
        }
    }
}
