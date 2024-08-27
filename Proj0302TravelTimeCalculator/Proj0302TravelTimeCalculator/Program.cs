namespace Proj0302TravelTimeCalculator {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the travel time calculator!");

            string choice = "y";

            while (choice == "y") {
                // Get user input - miles, mph
                Console.Write("Enter miles traveled: ");
                double miles = Double.Parse(Console.ReadLine());
                Console.Write("Enter mph: ");
                double mph = Double.Parse(Console.ReadLine());
                Console.WriteLine("");

                // Do business logic: math to calculate hours, minutes
                double hours = miles / mph;
                //Console.WriteLine($"hours: {hours}");
                // Display Output
                int hoursInt = (int)hours;
                Console.WriteLine($"Hours:   {hoursInt}");
                double minutes = (int)(((miles / mph) - hoursInt) * 60);
                Console.WriteLine($"Minutes: {minutes}");
                Console.WriteLine("");
                Console.Write("Continue (y/n)? ");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("bye");
        }
    }
}
