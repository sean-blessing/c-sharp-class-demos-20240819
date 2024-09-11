namespace Chal02Arrowhead {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Arrowhead App!\n");
            Console.WriteLine("You will be prompted to enter the width of the arrowhead. " +
                "Enter the width and I will generate the arrowhead!\n");

            string choice = "y";
            while (choice == "y") {
                Console.Write("Arrowhead Width: ");
                int width = Int32.Parse(Console.ReadLine());
                int maxHeight = width / 2;
                if (maxHeight % 2 == 0) {
                    maxHeight++;
                }

                string arrowheadStr = "";
                for (int i = 0; i < maxHeight; i++) {
                    for (int j = 0; j < i; j++) {
                       Console.Write(">");
                    }
                    Console.WriteLine();
                }
                for (int i = maxHeight; i > 0; i--) {
                    for (int j = 0; j < i; j++) {
                        Console.Write(">");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("Continue (y/n)? ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Bye");
        }
    }
}
