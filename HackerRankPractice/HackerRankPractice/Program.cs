namespace HackerRankPractice {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, max number checker!");

            int maxVal = 0;

            Random rand = new Random();

            for (int i = 0; i < 10; i++) {
                int nbr = rand.Next(1, 100);
                Console.WriteLine($"nbr: {nbr}");
                maxVal = Math.Max(maxVal, nbr);
            }

            Console.WriteLine($"maxVal {maxVal}");

        }

    }
}
