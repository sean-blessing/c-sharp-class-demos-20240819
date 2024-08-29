namespace Ch07DataValidationDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Data Validation");

            int dieRoll = GetInt("Enter die roll: ", 1, 6);
            Console.WriteLine($"Die roll is {dieRoll}");

            double price = GetDouble("Enter price: ", 1.0, 100.0);
            Console.WriteLine($"Price is {price}");

            Console.WriteLine("bye");
        }


        // GetInt method which uses exception handling to validate data
        private static int GetInt(string prompt, int min, int max) {
            int number = 0;
            Boolean isValid = false;

            while (!isValid) {
                try {
                    Console.Write(prompt);
                    number = Int32.Parse(Console.ReadLine());
                    if (number < min) {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max) {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else {
                        break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid entry: please enter a valid integer.");
                    continue;
                }
            }

            return number;
        }

        // GetDouble method which uses data validation, rather than exception handling
        private static double GetDouble(string prompt, double min, double max) {
            double number = 0.0;
            Boolean isValid = false;

            while (!isValid) {
                    Console.Write(prompt);
                Boolean success = Double.TryParse(Console.ReadLine(), out number);
                if (!success) {
                    Console.WriteLine("Invalid entry: please enter a valid double.");
                }
                else {
                    if (number < min) {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max) {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else {
                        break;
                    }
                }
            }

            return number;
        }


    }
}
